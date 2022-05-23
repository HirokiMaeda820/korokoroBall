using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject exitObject;
    private bool teleportable = false;
 
    private void OnTriggerEnter(Collider other)
    {
        if (exitObject != null && teleportable)
        {
            other.transform.position= exitObject.transform.position;
            exitObject.GetComponent<Teleport>().teleportable = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        teleportable = true;
    }
}
