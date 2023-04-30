
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject farmAnimals; 
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
            xPos = Random.Range(-16, 24);
            Instantiate(farmAnimals, new Vector3(xPos, 0, -10), Quaternion.identity);
            yield return new WaitForSeconds(2f);

        }
    }

}