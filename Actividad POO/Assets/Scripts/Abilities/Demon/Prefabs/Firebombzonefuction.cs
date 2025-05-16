using UnityEngine;

public class Firebombzonefuction : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private GameObject parent;
    [SerializeField] private Ability abilityData;

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
            IDamageable damageable = other.GetComponent<IDamageable>();
            if (damageable != null)
            {
                damageable.TakeDamage(abilityData.abilityValue);
            }
            //other.GetComponent<Enemy>().lifesystem.TakeDamage(abilityData.abilityValue);
        }
    }
}
