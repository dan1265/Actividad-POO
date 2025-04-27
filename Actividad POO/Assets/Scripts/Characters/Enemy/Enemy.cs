using UnityEngine;

public class Enemy : CharactersBase
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Life == 0)
        {
            Destroy(gameObject);
        }
    }
}
