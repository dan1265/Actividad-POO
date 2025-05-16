using UnityEngine;

[System.Serializable]
public class Lifesystem
{
    private float maxLife;
    private float minLife;
    [SerializeField]private float currentLife;
    public float MaxLife { get => maxLife; set => maxLife = value; }
    public float MinLife { get => minLife; set => minLife = value; }
    public float CurrentLife { get => currentLife; set => currentLife = Mathf.Clamp(value, minLife, maxLife); }
    public Lifesystem(float maxLife, float minLife, float currentLife)
    {
        MaxLife = maxLife;
        MinLife = minLife;
        CurrentLife = currentLife;
    }

    public void Heal(float healAmount)
    {
        CurrentLife += healAmount;
    }

    public void TakeDamage(float damageAmount)
    {
        CurrentLife -= damageAmount;
    }
}
