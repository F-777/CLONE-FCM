using UnityEngine;

public class SlowMotionController : MonoBehaviour
{
    public float slowMotionScale = 0.3f; // Kecepatan saat slow-motion
    public float duration = 2f;         // Durasi slow-motion

    public void TriggerSlowMotion()
    {
        StartCoroutine(SlowMotionEffect());
    }

    private IEnumerator SlowMotionEffect()
    {
        Time.timeScale = slowMotionScale;
        yield return new WaitForSecondsRealtime(duration); // Waktu tetap berjalan normal
        Time.timeScale = 1f; // Kembali ke normal
    }
}
public class CinematicCameraController : MonoBehaviour
{
    public SlowMotionController slowMotionController;

    public void TriggerCinematic()
    {
        slowMotionController.TriggerSlowMotion();
        // Lanjutkan dengan logika cinematic...
    }
}
