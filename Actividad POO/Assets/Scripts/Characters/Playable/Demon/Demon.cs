using UnityEngine;

public class Demon : Playable
{
    [SerializeField] protected float regenerationTimer;
    [SerializeField] protected float regenerationSpeed;

    [SerializeField] private GameObject darkspear;
    [SerializeField] private GameObject firebomb;
    protected override void Awake()
    {
        base.Awake();

        abilities.Add(new Darkspear(null, 5f, gameObject, darkspear));
        abilities.Add(new Forceoftheabyss(null, 5f, gameObject));
        abilities.Add(new Firebomb(null, 5f, gameObject, firebomb));

        playerInput.actions["Ability1"].performed += ctx => abilities[0].Cast(gameObject);
        playerInput.actions["Ability2"].performed += ctx => abilities[1].Cast(gameObject);  
        playerInput.actions["Ability3"].performed += ctx => abilities[2].Cast(gameObject);
    }


    void Update()
    {
        LifeRegen();
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

    protected void LifeRegen()
    {
        if (Life < 100)
        {
            regenerationTimer -= Time.deltaTime;
        }

        if (regenerationTimer <= 0)
        {
            Life += 1;
            regenerationTimer = regenerationSpeed;
        }

        if (Life == 100)
        {
            regenerationTimer = regenerationSpeed;
        }
    }
}
