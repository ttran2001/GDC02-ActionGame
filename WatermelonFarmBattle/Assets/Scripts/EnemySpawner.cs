/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public int xPos;
    public int zPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while(true)
        {
            xPos = Random.Range(1, 50);
            zPos = Random.range(1, 31);
            Instantiate(enemy, new Vector3(xPos, 43, zPos), Quaternion.identity);
            yield return new WaitForSeconds(2f);

        }
    }

}
*/