using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator animator;
    public float speedThreshold = 0.1f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Kecepatan pemain
        float speed = rb.velocity.magnitude;
        animator.SetFloat("Speed", speed);

        // Animasi tendangan
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("IsKicking");
        }
    }

    private void HandleMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        bool isRunning = horizontal != 0 || vertical != 0;

        animator.SetBool("isRunning", isRunning);
    }

    private void HandleKick()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Tombol tendangan
        {
            animator.SetTrigger("isKicking");
        }
    }
}

public class UpgradeManager : MonoBehaviour
{
    public PlayerStats player;

    public void UpgradeSpeed()
    {
        player.UpgradeSpeed(1);
    }

    public void UpgradeStrength()
    {
        player.UpgradeStrength(1);
    }

    public void UpgradeAccuracy()
    {
        player.UpgradeAccuracy(1);
    }
}
