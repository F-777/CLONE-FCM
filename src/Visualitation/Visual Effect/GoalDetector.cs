public class GoalDetector : MonoBehaviour
{
    public int team1Score = 0;
    public int team2Score = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            // Misal ini gawang tim 2
            team1Score++;
            FindObjectOfType<DynamicUI>().UpdateScore(team1Score, team2Score);

            // Tampilkan notifikasi "GOAL!"
            FindObjectOfType<DynamicUI>().ShowNotification("GOAL!", 2f);
        }
    }
}

public class GoalDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            FindObjectOfType<GoalEffects>().PlayConfetti();
            FindObjectOfType<AudioManager>().PlayCrowdCheer();
        }
    }
}
