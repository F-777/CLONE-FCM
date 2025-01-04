using UnityEngine;
using UnityEngine.AI;

public class AIScript : MonoBehaviour
{
    public Transform ball;        // Referensi bola
    public Transform opponentGoal; // Gawang lawan
    public float kickDistance = 2f; // Jarak untuk menendang bola
    public float kickForce = 10f;  // Kekuatan tendangan

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        // Kejar bola
        agent.SetDestination(ball.position);

        // Jika dekat bola, tendang ke gawang
        if (Vector3.Distance(transform.position, ball.position) <= kickDistance)
        {
            KickBall();
        }
    }

    private void KickBall()
    {
        Vector3 direction = (opponentGoal.position - ball.position).normalized;
        ball.GetComponent<Rigidbody>().AddForce(direction * kickForce, ForceMode.Impulse);
    }
}
