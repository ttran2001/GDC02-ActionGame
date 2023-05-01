using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject farmAnimals;
    public float spawnRate;
    private int xPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        yield return new WaitForSeconds(spawnRate);
        while (true)
        {
            xPos = UnityEngine.Random.Range(-16, 24);
            Instantiate(farmAnimals, new Vector3(xPos, 0, -10), Quaternion.identity);
            yield return new WaitForSeconds(spawnRate);
        }
    }
}