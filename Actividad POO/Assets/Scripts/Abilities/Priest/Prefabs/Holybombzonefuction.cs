using UnityEngine;

public class Holybombzonefuction : MonoBehaviour
{
    [SerializeField] private float timer;
    [SerializeField]private GameObject parent;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(parent);
        }
        float sizeUpdate = Mathf.Lerp(5, 8, timer / 4);
        parent.transform.localScale = new Vector3(sizeUpdate, 0.1f, sizeUpdate);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            other.GetComponent<Enemy>().Getdamage(1);
        }
    }
}
