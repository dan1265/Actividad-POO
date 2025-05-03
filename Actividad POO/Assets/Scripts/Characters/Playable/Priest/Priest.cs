using UnityEngine;
using UnityEngine.InputSystem;

public class Priest : Playable
{
    [SerializeField] private float mana;
    [SerializeField] protected float regenerationTimer;
    [SerializeField] protected float regenerationSpeed;

    public float Mana
    {
        get => mana;
        set
        {
            if (value < 0)
                mana = 0;
            else if (value > 100)
                mana = 100;
            else
                mana = value;
        }
    }

    [SerializeField] private GameObject holylight;
    [SerializeField] private GameObject holybomb;
    protected override void Awake()
    {
        base.Awake();

        Mana = 100;

        abilities.Add(new Holylight(null, 2.5f, gameObject, holylight));
        abilities.Add(new Restauration(null, 10f, gameObject));
        abilities.Add(new Holybomb(null, 7f, gameObject, holybomb));
    }

    // Update is called once per frame
    void Update()
    {
        ManaRegen();
        CDUpdate();
        CastSelector();
    }

    protected void ManaRegen()
    {
        if (Mana < 100)
        {
            regenerationTimer -= Time.deltaTime;
        }

        if (regenerationTimer <= 0)
        {
            Mana += 1;
            regenerationTimer = regenerationSpeed;
        }

        if (Mana == 100)
        {
            regenerationTimer = regenerationSpeed;
        }
    }
}
