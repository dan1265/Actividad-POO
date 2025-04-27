using UnityEngine;
using UnityEngine.InputSystem;

[System.Serializable]
public class Playable : CharactersBase
{
    [SerializeField] private float mana;
    [SerializeField] protected float regeneration;

    protected PlayerInput playerInput;

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

    protected override void Awake()
    {
        base.Awake();
        playerInput = GetComponent<PlayerInput>();
    }
}
