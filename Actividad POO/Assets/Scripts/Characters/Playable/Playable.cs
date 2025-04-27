using UnityEngine;
using UnityEngine.InputSystem;

[System.Serializable]
public class Playable : CharactersBase
{
    [SerializeField] protected float mana;
    protected PlayerInput playerInput;

    protected override void Awake()
    {
        base.Awake();
        playerInput = GetComponent<PlayerInput>();
    }
}
