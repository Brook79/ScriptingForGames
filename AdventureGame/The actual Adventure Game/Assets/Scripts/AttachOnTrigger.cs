using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AttachOnTrigger : MonoBehaviour
{
    public UnityEvent triggerEvent;
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Vector3 coolposition = new Vector3(other.transform.position.x + 0.5f, other.transform.position.y, other.transform.position.z);
            transform.position = coolposition;
            transform.parent = other.transform;
            triggerEvent.Invoke();
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
