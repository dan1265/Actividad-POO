using UnityEngine;
using UnityEngine.InputSystem;

public class Priest : Playable
{
    [SerializeField] private GameObject holylight;
    [SerializeField] private GameObject holybomb;
    protected override void Awake()
    {
        base.Awake();

        abilities.Add(new Holylight(null, 2.5f));
        abilities.Add(new Restauration(null, 10f));
        abilities.Add(new Holybomb(null, 7f));

        playerInput.actions["Ability1"].performed += ctx => abilities[0].Cast(gameObject);
        playerInput.actions["Ability2"].performed += ctx => abilities[1].Cast(gameObject);
        playerInput.actions["Ability3"].performed += ctx => abilities[2].Cast(gameObject);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        foreach (var ability in abilities)
        {

            if (ability.cDtimer >= 0)
            {
                ability.cDtimer -= Time.deltaTime;
            }       
        }

        ManaRegen();
    }

    public void HolylightAbility()
    {
        GameObject hL = Instantiate(holylight, Camera.main.transform.position, Camera.main.transform.rotation);
        hL.GetComponent<Holylightfunction>().damage = abilities[0].DamageOrHeal;
    }
    public void RestaurationAbility()
    {
        Heal(abilities[1].DamageOrHeal);
    }
    public void HolybombAbility()
    {
        GameObject hB = Instantiate(holybomb, transform.position, Camera.main.transform.rotation);
        hB.GetComponent<Holybombfunction>().damage = abilities[2].DamageOrHeal;
    }

    private void ManaRegen()
    {
        if (Mana < 100)
        {
            regeneration -= Time.deltaTime;
        }

        if (regeneration <= 0)
        {
            Mana += 1;
            regeneration = 5;
        }
    }
}
