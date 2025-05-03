using System.Collections.Generic;
using UnityEngine;

public abstract class CharactersBase : MonoBehaviour
{
    [SerializeField] private float life;

    public float Life 
    { 
        get => life;
        set 
        {
            if (value < 0)
                life = 0;
            else if (value > 100)
                life = 100;
            else
                life = value;
        }
         
    }

    protected virtual void Awake()
    {

    }

    public void Getdamage(float damage)
    {
        Life -= damage;
    }

    public void Heal(float heal) 
    {
        Life += heal;
    }
}
