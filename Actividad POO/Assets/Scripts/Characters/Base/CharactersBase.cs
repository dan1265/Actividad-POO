using System.Collections.Generic;
using UnityEngine;

public abstract class CharactersBase : MonoBehaviour
{
    [SerializeField] private float life;
    [SerializeField] protected List<Ability> abilities = new List<Ability>();

    public float Life 
    { 
        get => life; 
        set => life = value; 
    }

    protected virtual void Awake()
    {

    }

}
