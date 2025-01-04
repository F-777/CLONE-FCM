public class CutsceneController : MonoBehaviour
{
    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        audioManager.PlayWhistle(); // Peluit tanda masuk lapangan
        audioManager.PlayCrowdCheer(); // Sorakan penonton
    }
}
