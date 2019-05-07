using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject crazySphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootSphere();
    }

    void ShootSphere()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(crazySphere, spawnPosition.position, spawnPosition.rotation);
        }
    }
}
