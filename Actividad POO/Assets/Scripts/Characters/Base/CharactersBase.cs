using System.Collections.Generic;
using UnityEngine;

public abstract class CharactersBase : MonoBehaviour
{
    public Lifesystem lifesystem;
    protected virtual void Awake()
    {
        lifesystem = new Lifesystem(100, 0, 100);
    }
}
