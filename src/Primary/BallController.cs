using UnityEngine;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Add force to the ball when hit by player
            rb.AddForce(collision.contacts[0].normal * 10f, ForceMode.Impulse);
        }
    }
}
