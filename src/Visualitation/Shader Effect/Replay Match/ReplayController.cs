using UnityEngine;

public class ReplayController : MonoBehaviour
{
    public Camera replayCamera;       // Kamera khusus untuk replay
    public Transform ball;           // Referensi bola
    public Transform[] replayPoints; // Posisi kamera selama replay
    public float transitionSpeed = 2f; // Kecepatan transisi kamera
    public float replayDuration = 5f; // Durasi replay

    private bool isReplaying = false;

    private void Start()
    {
        replayCamera.enabled = false; // Nonaktifkan kamera replay di awal
    }

    public void TriggerReplay()
    {
        if (!isReplaying)
        {
            StartCoroutine(PlayReplay());
        }
    }

    private IEnumerator PlayReplay()
    {
        isReplaying = true;

        // Aktifkan kamera replay
        replayCamera.enabled = true;

        foreach (Transform point in replayPoints)
        {
            // Kamera bergerak ke posisi berikutnya
            while (Vector3.Distance(replayCamera.transform.position, point.position) > 0.1f)
            {
                replayCamera.transform.position = Vector3.Lerp(replayCamera.transform.position, point.position, Time.deltaTime * transitionSpeed);
                replayCamera.transform.rotation = Quaternion.Lerp(replayCamera.transform.rotation, point.rotation, Time.deltaTime * transitionSpeed);
                yield return null;
            }

            // Tunggu sebentar di posisi ini
            yield return new WaitForSeconds(replayDuration / replayPoints.Length);
        }

        // Kembali ke kamera utama
        replayCamera.enabled = false;
        isReplaying = false;
    }
}
