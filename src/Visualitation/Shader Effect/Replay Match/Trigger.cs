public class GoalDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            FindObjectOfType<AudioManager>().PlayCrowdCheer(); // Suara sorakan
            FindObjectOfType<CinematicCameraController>().TriggerCinematic(); // Cinematic gol
            FindObjectOfType<ReplayController>().TriggerReplay(); // Replay gol
        }
    }
}

public class GoalEffects : MonoBehaviour
{
    public ParticleSystem confettiEffect;

    public void PlayConfetti()
    {
        if (confettiEffect != null)
        {
            confettiEffect.Play();
        }
    }
}
