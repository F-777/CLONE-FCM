using UnityEngine;

public class BallEffect : MonoBehaviour
{
    private TrailRenderer trailRenderer;
    private Rigidbody rb;

    private void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
        rb = GetComponent<Rigidbody>();
        trailRenderer.enabled = false;
    }

    private void Update()
    {
        if (rb.velocity.magnitude > 5f) // Aktif jika kecepatan bola > 5
        {
            trailRenderer.enabled = true;
        }
        else
        {
            trailRenderer.enabled = false;
        }
    }
}
