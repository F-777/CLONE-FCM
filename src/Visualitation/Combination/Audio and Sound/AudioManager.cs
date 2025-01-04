using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource kickSource;
    public AudioClip[] kickSounds; // Array suara tendangan
    public AudioSource crowdSource;
    public AudioClip[] cheerSounds; // Array suara sorakan

    public void PlayKickSound()
    {
        int randomIndex = Random.Range(0, kickSounds.Length);
        kickSource.clip = kickSounds[randomIndex];
        kickSource.Play();
    }

    public void PlayCrowdCheer()
    {
        int randomIndex = Random.Range(0, cheerSounds.Length);
        crowdSource.clip = cheerSounds[randomIndex];
        crowdSource.Play();
    }
}
