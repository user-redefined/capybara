using UnityEngine;

/// <summary>
/// Scene entity control class.
/// </summary>
public class Entity : MonoBehaviour
{
    public int PlayerID { get; private set; }
    private MeshRenderer meshRenderer;
    private Color teamColor;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Destroy(gameObject);
    }

    public void OnCreate(int id, Color color)
    {
        PlayerID = id;
        teamColor = color;
    }

    private void OnMouseOver() => meshRenderer.material.color = Color.green;
    private void OnMouseExit() => meshRenderer.material.color = teamColor;
}