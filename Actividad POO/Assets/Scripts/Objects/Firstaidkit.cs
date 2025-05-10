using UnityEngine;

public class Firstaidkit : MonoBehaviour
{
    [SerializeField] private float amplitude;
    [SerializeField] private float frequency;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 1 + (Mathf.Sin(Time.time * frequency) * amplitude), 0);
    }

}
