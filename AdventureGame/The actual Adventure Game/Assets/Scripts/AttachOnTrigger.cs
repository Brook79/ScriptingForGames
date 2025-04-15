using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 coolposition = new Vector3(other.transform.position.x + 0.5f, other.transform.position.y, other.transform.position.z);
            transform.position = coolposition;
            transform.parent = other.transform; 
        }
    }
    public void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }

    public void DestroyMe()
    {
        Destroy(gameObject);
    }
}
