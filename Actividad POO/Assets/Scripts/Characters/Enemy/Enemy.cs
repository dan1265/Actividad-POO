using UnityEngine;

public class Enemy : CharactersBase
{
    [SerializeField] private Material baseMaterial;

    private Material instanceMaterial;
    private Renderer _renderer;

    void Start()
    {
        _renderer = GetComponent<Renderer>();

        instanceMaterial = new Material(baseMaterial);
        _renderer.material = instanceMaterial;
    }

    void Update()
    {
        if (instanceMaterial != null)
        {
            instanceMaterial.color = Color.Lerp(Color.red, Color.yellow, lifesystem.CurrentLife / 100f);
        }

        if (lifesystem.CurrentLife <= 0)
        {
            Destroy(gameObject);
        }
    }
}