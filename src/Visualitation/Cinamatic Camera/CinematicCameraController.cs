using UnityEngine;

public class CinematicCameraController : MonoBehaviour
{
    public Transform ball;            // Referensi bola
    public Transform goal;            // Referensi gawang
    public float cinematicDuration = 3f; // Durasi cinematic
    public float zoomFOV = 30f;       // FOV saat zoom
    public float rotationSpeed = 50f; // Kecepatan rotasi kamera

    private Camera cam;
    private float originalFOV;
    private bool isCinematicActive = false;
    private float cinematicTimer = 0f;

    private void Start()
    {
        cam = GetComponent<Camera>();
        originalFOV = cam.fieldOfView;
    }

    private void Update()
    {
        if (isCinematicActive)
        {
            CinematicFollow();
        }
    }

    public void TriggerCinematic()
    {
        isCinematicActive = true;
        cinematicTimer = cinematicDuration;

        // Slow motion efek
        Time.timeScale = 0.5f; 
    }

    private void CinematicFollow()
    {
        if (cinematicTimer > 0)
        {
            // Zoom ke bola
            cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, zoomFOV, Time.deltaTime * 2f);

            // Rotasi kamera mengelilingi bola
            transform.RotateAround(ball.position, Vector3.up, rotationSpeed * Time.deltaTime);
            transform.LookAt(ball.position);

            cinematicTimer -= Time.deltaTime;
        }
        else
        {
            ResetCinematic();
        }
    }

    private void ResetCinematic()
    {
        isCinematicActive = false;
        cam.fieldOfView = originalFOV;
        Time.timeScale = 1f; // Normal kembali
    }
}
