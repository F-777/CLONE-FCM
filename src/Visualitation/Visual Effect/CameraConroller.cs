using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform ball;      // Referensi bola
    public float smoothSpeed = 0.125f;
    public Vector3 offset;      // Offset kamera dari bola

    private void LateUpdate()
    {
        Vector3 desiredPosition = ball.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(ball);
    }

    public void ZoomIn()
    {
        StartCoroutine(ZoomEffect(30f, 1f)); // Zoom ke FOV 30 dalam 1 detik
    }

    private IEnumerator ZoomEffect(float targetFOV, float duration)
    {
        Camera cam = GetComponent<Camera>();
        float startFOV = cam.fieldOfView;
        float time = 0f;

        while (time < duration)
        {
            cam.fieldOfView = Mathf.Lerp(startFOV, targetFOV, time / duration);
            time += Time.deltaTime;
            yield return null;
        }

        cam.fieldOfView = targetFOV;
    }
}

FindObjectOfType<CameraController>().ZoomIn();
