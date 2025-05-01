using UnityEngine;
using UnityEngine.InputSystem;

public class Priest : Playable
{
    [SerializeField] protected float regenerationTimer;
    [SerializeField] protected float regenerationSpeed;

    [SerializeField] private GameObject holylight;
    [SerializeField] private GameObject holybomb;
    protected override void Awake()
    {
        base.Awake();

        Mana = 100;

        abilities.Add(new Holylight(null, 2.5f, gameObject, holylight));
        abilities.Add(new Restauration(null, 10f, gameObject));
        abilities.Add(new Holybomb(null, 7f, gameObject, holybomb));

        playerInput.actions["Ability1"].performed += ctx => abilities[0].Cast(gameObject);
        playerInput.actions["Ability2"].performed += ctx => abilities[1].Cast(gameObject);
        playerInput.actions["Ability3"].performed += ctx => abilities[2].Cast(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        ManaRegen();
        CDUpdate();
    }

    private void CDUpdate()
    {
        foreach (var ability in abilities)
        {

            if (ability.cDtimer >= 0)
            {
                ability.cDtimer -= Time.deltaTime;
            }
        }
    }
    public void RefUpdate()
    {
        foreach (var ability in abilities)
        {
            ability.RefUpdate();
        }
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
