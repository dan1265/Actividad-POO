using UnityEngine;
using UnityEngine.InputSystem;

public class Priest : Playable
{
    [SerializeField] private GameObject holylight;
    [SerializeField] private GameObject holybomb;
    protected override void Awake()
    {
        base.Awake();

        abilities.Add(new Holylight(null, 5f));
        abilities.Add(new Restauration(null, 5f));
        abilities.Add(new Holybomb(null, 5f));

        playerInput.actions["Ability1"].performed += ctx => Cast1();
        playerInput.actions["Ability2"].performed += ctx => Cast2();
        playerInput.actions["Ability3"].performed += ctx => Cast3();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }

    private void Cast1()
    {
        GameObject hL = Instantiate(holylight, transform.position, Camera.main.transform.rotation);
    }
    private void Cast2()
    {

    }
    private void Cast3()
    {

    }
}
