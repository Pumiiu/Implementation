using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TouchLight : MonoBehaviour
{
    public GameObject lightObject;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lightObject.SetActive(true);
        }
    }
}
