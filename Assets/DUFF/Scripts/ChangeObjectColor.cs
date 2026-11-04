using UnityEngine;

public class CangeObjectColor : MonoBehaviour
{
    [SerializeField] private Color tint = Color.violet;
    private Material runtimeMaterial;

    public Color Tint
    {
        get { return tint; }
        set { tint = value; }
    }

    private void Start()
    {
        runtimeMaterial = GetComponent<Renderer>().material;
        runtimeMaterial.color = Tint;
    }

    private void OnDestroy()
    {
        if (runtimeMaterial != null)
        {
            Destroy(runtimeMaterial);
        }
    }
}