using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform ball;          // Referensi bola
    public Transform opponentGoal;  // Gawang lawan (tujuan menyerang)
    public float speed = 4f;        // Kecepatan AI
    public float chaseRadius = 10f; // Jarak pengejaran bola

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Act();
    }

    private void Act()
    {
        // Jika bola berada dalam radius pengejaran, AI akan mengejarnya
        if (Vector3.Distance(transform.position, ball.position) <= chaseRadius)
        {
            ChaseBall();
        }
        else
        {
            Defend();
        }
    }

    private void ChaseBall()
    {
        Vector3 direction = (ball.position - transform.position).normalized;
        rb.velocity = direction * speed;

        // Rotasi AI menghadap bola
        transform.LookAt(new Vector3(ball.position.x, transform.position.y, ball.position.z));
    }

    private void Defend()
    {
        // Posisi bertahan: AI bergerak di depan gawang
        Vector3 defendPosition = new Vector3(opponentGoal.position.x, transform.position.y, opponentGoal.position.z - 5f);
        Vector3 direction = (defendPosition - transform.position).normalized;
        rb.velocity = direction * (speed / 2);

        // Rotasi AI menghadap gawang
        transform.LookAt(opponentGoal);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            // Tendang bola ke arah gawang lawan saat AI menyentuh bola
            Rigidbody ballRb = ball.GetComponent<Rigidbody>();
            Vector3 kickDirection = (opponentGoal.position - ball.position).normalized;
            ballRb.AddForce(kickDirection * 10f, ForceMode.Impulse);
        }
    }
}
