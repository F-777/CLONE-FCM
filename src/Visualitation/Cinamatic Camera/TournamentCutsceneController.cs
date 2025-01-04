using UnityEngine;

public class TournamentCutsceneController : MonoBehaviour
{
    public Animator playerAnimator;    // Animator pemain
    public Camera cinematicCamera;    // Kamera khusus untuk cutscene
    public GameObject confettiEffect; // Efek konfeti
    public AudioSource victoryMusic;  // Musik kemenangan

    public void PlayCutscene()
    {
        // Aktifkan kamera cinematic
        cinematicCamera.gameObject.SetActive(true);

        // Mainkan animasi selebrasi
        playerAnimator.SetTrigger("Celebrate");

        // Aktifkan efek konfeti
        confettiEffect.SetActive(true);

        // Mainkan musik kemenangan
        if (victoryMusic != null)
        {
            victoryMusic.Play();
        }

        // Timer untuk kembali ke menu utama
        Invoke("ReturnToMenu", 10f);
    }

    private void ReturnToMenu()
    {
        // Kembali ke menu utama
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
