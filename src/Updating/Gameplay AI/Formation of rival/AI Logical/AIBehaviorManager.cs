using UnityEngine;

public class AIBehaviorManager : MonoBehaviour
{
    public Transform ball;
    public Transform goal;
    public Transform defensivePosition;

    public enum AIState { Attack, Defend }
    public AIState state;

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        switch (state)
        {
            case AIState.Attack:
                agent.SetDestination(ball.position); // Kejar bola
                break;
            case AIState.Defend:
                agent.SetDestination(defensivePosition.position); // Kembali ke posisi bertahan
                break;
        }
    }

    public void SetState(AIState newState)
    {
        state = newState;
    }
}
