using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopFoeld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
       //Debug.Log(other.name);
        GameObject otherObject = other.gameObject;
        Rigidbody otherRigidbody = otherObject.GetComponent<Rigidbody>();
        otherRigidbody.velocity = new Vector3(0, 0, 0);
    }
}
