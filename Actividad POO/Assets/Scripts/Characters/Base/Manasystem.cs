using UnityEngine;

[System.Serializable]
public class Manasystem
{
    private float maxMana;
    private float minMana;
    [SerializeField] private float currentMana;

    [SerializeField] private float regenerationTimer;
    [SerializeField] public float regenerationSpeed;

    public float MaxMana { get => maxMana; set => maxMana = value; }
    public float MinMana { get => minMana; set => minMana = value; }
    public float CurrentMana { get => currentMana; set => currentMana = Mathf.Clamp(value, minMana, maxMana); }
    private enum regenerationMode{Time, Instant}

    [SerializeField] regenerationMode regMode;
    public Manasystem(float maxMana, float minMana, float currentMana)
    {
        MaxMana = maxMana;
        MinMana = minMana;
        CurrentMana = currentMana;
    }

    public void ManaRegen()
    {
        if(regMode == regenerationMode.Time)
        {
            if (CurrentMana < 100)
            {
                regenerationTimer -= Time.deltaTime;
            }

            if (regenerationTimer <= 0)
            {
                CurrentMana += 1;
                regenerationTimer = regenerationSpeed;
            }

            if (CurrentMana == 100)
            {
                regenerationTimer = regenerationSpeed;
            }
        }
        if(regMode == regenerationMode.Instant)
        {
            if(CurrentMana != 100)
            {
                CurrentMana = 100;
            }
        }
    }

    public void UseMana(float amount)
    {
        currentMana -= amount;
    }
}
