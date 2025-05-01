using UnityEngine;

public class Firebombzonefuction : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private GameObject parent;
    private Demon player;
    public float damage;

    private void OnEnable()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Demon>();
        Firebomb.Firebombdamage += Damage;
        player.RefUpdate();
    }
    private void OnDisable()
    {
        Firebomb.Firebombdamage -= Damage;
    }

    private void Damage(float inDamage)
    {
        damage = inDamage;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(parent);
        }
        float sizeUpdate = Mathf.Lerp(6, 7, timer / 4);
        parent.transform.localScale = new Vector3(sizeUpdate, parent.transform.localScale.y, sizeUpdate);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().Getdamage(damage);
        }
    }
}
