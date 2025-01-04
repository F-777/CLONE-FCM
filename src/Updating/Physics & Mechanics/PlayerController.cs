using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;       // Kecepatan gerak
    public float kickPower = 10f;     // Kekuatan tendangan
    public Transform ball;            // Referensi bola

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        Kick();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        rb.velocity = direction * moveSpeed;
    }

    private void Kick()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Tendang bola saat tombol Space ditekan
        {
            if (ball != null)
            {
                Vector3 direction = (ball.position - transform.position).normalized;
                Rigidbody ballRb = ball.GetComponent<Rigidbody>();
                ballRb.AddForce(direction * kickPower, ForceMode.Impulse);
            }
        }
    }
}