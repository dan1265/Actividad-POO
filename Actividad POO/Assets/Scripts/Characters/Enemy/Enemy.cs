using UnityEngine;

public class Enemy : CharactersBase, IDamageable
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
        ChangeColor();
        Dead();
    }

    void ChangeColor()
    {
        if (instanceMaterial != null)
        {
            instanceMaterial.color = Color.Lerp(Color.red, Color.yellow, lifesystem.CurrentLife / 100f);
        }
    }
    void Dead()
    {
        if (lifesystem.CurrentLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float damage)
    {
        lifesystem.TakeDamage(damage);
    }

    public void Heal(float amount)
    {
        lifesystem.Heal(amount);
    }
}