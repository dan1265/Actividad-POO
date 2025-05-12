using System.Collections;
using UnityEngine;

public class Enemyspawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
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

        if(transform.childCount == 0)
        {
        GameObject enemy = Instantiate(_enemy, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity);
        enemy.transform.SetParent(transform);
        }
    }

    private IEnumerator Dead()
    {
        yield return hasSpawned = false;
    }
}
