using UnityEngine;

public class GoalSlowMotion : MonoBehaviour
{
    public float slowMotionFactor = 0.3f; // Kecepatan slow motion
    public float slowDuration = 2f;      // Durasi slow motion

    private bool isGoalTriggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball") && !isGoalTriggered)
        {
            isGoalTriggered = true;
            StartCoroutine(SlowMotionEffect());
        }
    }

    private IEnumerator SlowMotionEffect()
    {
        Time.timeScale = slowMotionFactor;
        yield return new WaitForSecondsRealtime(slowDuration);
        Time.timeScale = 1f; // Kembali ke normal
    }
}
