using UnityEngine;

public class AIPosition : MonoBehaviour
{
    public Vector3 defaultPosition;

    private void Start()
    {
        defaultPosition = transform.position;
    }
}
