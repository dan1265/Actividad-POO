using UnityEngine;

[System.Serializable]
public class Playable : CharactersBase
{
    [SerializeField] protected float mana;
    public Playable(float life, float mana) : base(life)
    {
        this.mana = mana;
    }



}
