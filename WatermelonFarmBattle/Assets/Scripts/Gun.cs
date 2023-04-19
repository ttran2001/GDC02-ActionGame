using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using System;
using System.Security.Cryptography;

public class Gun : MonoBehaviour
{
    private StarterAssetsInputs _input;
    [SerializeField]
    private GameObject pelletPrefab;
    [SerializeField]
    private GameObject pelletPoint;
    [SerializeField]
    private float pelletSpeed = 800;

    // Start is called before the first frame update
    void Start()
    {
        _input = transform.root.GetComponent<StarterAssetsInputs>();
    }

    // Update is called once per frame
    void Update()
    {
        if(_input.shoot)
        {
            Shoot();
            _input.shoot = false;
        }
    }

    void Shoot()
    {
        Debug.Log("shoot!");
        GameObject pellet = Instantiate(pelletPrefab, pelletPoint.transform.position, transform.rotation);
        pellet.GetComponent<Rigidbody>().AddForce(transform.forward * pelletSpeed);
        Destroy(pellet, 1); 
    
    }
}
