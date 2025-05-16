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
        transform.position = new Vector3(transform.position.x, 1 + (Mathf.Sin(Time.time * frequency) * amplitude), transform.position.z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            if (other.GetComponent<Priest>())
            {
                other.GetComponent<Priest>().lifesystem.Heal(30f);
                other.GetComponent<Priest>().mana.CurrentMana += 30;
            }
            if (other.GetComponent<Demon>())
            {
                other.GetComponent<Demon>().lifesystem.Heal(30f);
            }
            Destroy(gameObject);
        }

    }
}
