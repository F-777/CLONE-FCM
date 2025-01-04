using UnityEngine;

public class GoalEffect : MonoBehaviour
{
    public ParticleSystem goalEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            goalEffect.Play();
        }
    }
}
