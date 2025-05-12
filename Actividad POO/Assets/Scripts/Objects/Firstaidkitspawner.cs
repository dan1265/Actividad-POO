using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Firstaidkitspawner : MonoBehaviour
{
    [SerializeField] private GameObject _firstaidkit;
    [SerializeField] private float timer = 10f;
    [SerializeField] public bool hasSpawned = false;

    private void Update()
    {
        if (!hasSpawned && transform.childCount == 0)
        {
            StartCoroutine(CheckSpawn());
        }
        if (transform.childCount == 0)
        {
            StartCoroutine(Dead());
        }
    }

    private IEnumerator CheckSpawn()
    {
        hasSpawned = true;

        yield return new WaitForSeconds(timer);

        if (transform.childCount == 0)
        {
            GameObject firstaid = Instantiate(_firstaidkit, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
            firstaid.transform.SetParent(transform);
        }
    }
    private IEnumerator Dead()
    {
        yield return hasSpawned = false;
    }
}
