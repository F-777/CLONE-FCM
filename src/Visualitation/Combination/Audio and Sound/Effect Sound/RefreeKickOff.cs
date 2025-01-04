public class MatchManager : MonoBehaviour
{
    private AudioManager audioManager;

    private void Start()
    {
        audioManager = FindObjectOfType<AudioManager>();
        audioManager.PlayWhistle(); // Peluit tanda mulai
    }

    private void EndMatch()
    {
        audioManager.PlayWhistle(); // Peluit tanda akhir
    }
}
