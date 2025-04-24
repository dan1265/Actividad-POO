using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public abstract class CharactersBase : MonoBehaviour
{
    [SerializeField] private float life;
    [SerializeField] protected List<Ability> abilities = new List<Ability>();
    public float Life 
    { 
        get => life; 
        set => life = value; 
    }
    public CharactersBase(float life)
    {
        Life = life;
    }

    public string DisplayAbilities()
    {
        string result = string.Empty;

        foreach (Ability ability in abilities)
        {
            result += ability.DisplayInfo() + "\n";
        }

        return result;
    }

}
