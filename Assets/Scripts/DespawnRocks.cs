using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnRocks : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Rock")
        {
            Destroy(other.gameObject);
        }
        
    }
}
