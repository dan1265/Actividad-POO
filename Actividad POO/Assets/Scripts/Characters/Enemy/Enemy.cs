using UnityEngine;

public class Enemy : CharactersBase
{
    [SerializeField] private Material color;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        color.color = Color.Lerp(Color.red, Color.green, Life/100);
        if (Life == 0)
        {
            Destroy(gameObject);
        }
    }
}
