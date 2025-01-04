using UnityEngine;

public class BallController : MonoBehaviour
{
    public float kickForce = 15f; // Gaya tendangan
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Deteksi tabrakan antara bola dan pemain
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 direction = collision.contacts[0].normal; // Arah kontak
            rb.AddForce(-direction * kickForce, ForceMode.Impulse);
        }
    }
}

private void OnTriggerEnter(Collider other)
{
    if (other.CompareTag("Goal_Player"))
    {
        FindObjectOfType<HUDManager>().UpdateScore(false); // Gol untuk lawan
    }
    else if (other.CompareTag("Goal_Opponent"))
    {
        FindObjectOfType<HUDManager>().UpdateScore(true); // Gol untuk pemain
    }
}
