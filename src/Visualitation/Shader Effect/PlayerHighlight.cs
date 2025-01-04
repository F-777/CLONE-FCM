using UnityEngine;

public class PlayerHighlight : MonoBehaviour
{
    public Material highlightMaterial;   // Material highlight
    private Material originalMaterial;  // Material asli
    private Renderer playerRenderer;

    private void Start()
    {
        playerRenderer = GetComponent<Renderer>();
        originalMaterial = playerRenderer.material;
    }

    private void OnMouseEnter()
    {
        playerRenderer.material = highlightMaterial;
    }

    private void OnMouseExit()
    {
        playerRenderer.material = originalMaterial;
    }
}
