using UnityEngine;

public class Holybombzonefuction : MonoBehaviour
{
    [SerializeField] private float timer;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
        float sizeUpdate = Mathf.Lerp(5, 8, timer / 4);
        transform.localScale = new Vector3(sizeUpdate, 0.1f, sizeUpdate);
    }
}
