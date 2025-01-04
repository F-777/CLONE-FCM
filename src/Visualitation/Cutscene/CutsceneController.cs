using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    public Transform[] cameraPositions; // Posisi kamera untuk cutscene
    public float transitionSpeed = 2f;  // Kecepatan transisi antar posisi
    public float waitTime = 2f;         // Durasi menunggu di tiap posisi

    private Camera cam;
    private int currentPosIndex = 0;
    private bool isCutsceneActive = true;

    private void Start()
    {
        cam = Camera.main;
        StartCoroutine(PlayCutscene());
    }

    private IEnumerator PlayCutscene()
    {
        while (currentPosIndex < cameraPositions.Length)
        {
            Transform targetPosition = cameraPositions[currentPosIndex];

            // Pindahkan kamera ke posisi target
            while (Vector3.Distance(cam.transform.position, targetPosition.position) > 0.1f)
            {
                cam.transform.position = Vector3.Lerp(cam.transform.position, targetPosition.position, Time.deltaTime * transitionSpeed);
                cam.transform.rotation = Quaternion.Lerp(cam.transform.rotation, targetPosition.rotation, Time.deltaTime * transitionSpeed);
                yield return null;
            }

            // Tunggu di posisi ini sebelum ke posisi berikutnya
            yield return new WaitForSeconds(waitTime);

            currentPosIndex++;
        }

        // Selesai cutscene, aktifkan gameplay
        isCutsceneActive = false;
        EnableGameplay();
    }

    private void EnableGameplay()
    {
        // Aktifkan kontrol pemain
        FindObjectOfType<PlayerController>().enabled = true;

        // Kembalikan kamera ke mode gameplay
        cam.GetComponent<CameraController>().enabled = true;
    }
}
