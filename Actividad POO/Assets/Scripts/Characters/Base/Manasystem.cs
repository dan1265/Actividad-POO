using UnityEngine;

[System.Serializable]
public class Manasystem
{
    private float maxMana;
    private float minMana;
    [SerializeField] private float currentMana;
    public float MaxMana { get => maxMana; set => maxMana = value; }
    public float MinMana { get => minMana; set => minMana = value; }
    public float CurrentMana { get => currentMana; set => currentMana = Mathf.Clamp(value, minMana, maxMana); }
    public Manasystem(float maxMana, float minMana, float currentMana)
    {
        MaxMana = maxMana;
        MinMana = minMana;
        CurrentMana = currentMana;
    }

    public void RegenarateMana(float amount)
    {
        CurrentMana += amount;
    }

    public void UseMana(float amount)
    {
        currentMana -= amount;
    }
}
