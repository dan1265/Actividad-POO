using UnityEngine;

[System.Serializable]
public class Priest : Playable
{
    public Priest(float life, float mana) : base(life, mana)
    {

    }
    private void Awake()
    {
        abilities.Add(new Holylight(null, "Holy Light", "Summons a beam of holy light that deals damage to the first enemy it hits.", 5f));
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Debug.Log(DisplayAbilities());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
