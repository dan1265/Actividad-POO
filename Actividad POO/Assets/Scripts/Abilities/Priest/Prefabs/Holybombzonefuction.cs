using UnityEngine;

public class Holybombzonefuction : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField] private GameObject parent;
    [SerializeField] private Abilityscriptable abilityData;

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
            other.GetComponent<Enemy>().Getdamage(abilityData.abilityValue);
        }
    }
}
