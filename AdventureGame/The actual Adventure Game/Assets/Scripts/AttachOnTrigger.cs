using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachOnTrigger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        transform.position += new Vector3(0.7f, -0.02f, 0);
        transform.parent = other.transform;
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
