using UnityEngine;

public class FormationController : MonoBehaviour
{
    public Transform ball;
    public Transform[] positions; // Posisi formasi (misalnya 4-4-2)
    public float speed = 4f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MoveInFormation();
    }

    private void MoveInFormation()
    {
        foreach (Transform position in positions)
        {
            if (Vector3.Distance(position.position, ball.position) < 5f)
            {
                ChaseBall(position);
            }
            else
            {
                ReturnToFormation(position);
            }
        }
    }

    private void ChaseBall(Transform position)
    {
        Vector3 direction = (ball.position - position.position).normalized;
        position.position += direction * speed * Time.deltaTime;
    }

    private void ReturnToFormation(Transform position)
    {
        // Posisi default dalam formasi
        Vector3 defaultPosition = position.GetComponent<AIPosition>().defaultPosition;
        Vector3 direction = (defaultPosition - position.position).normalized;
        position.position += direction * (speed / 2) * Time.deltaTime;
    }
}
