public class GoalDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            FindObjectOfType<CinematicCameraController>().TriggerCinematic();
            // Tambahkan suara sorakan
            FindObjectOfType<AudioManager>().PlayCrowdCheer();
        }
    }
}
