using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDMatch : MonoBehaviour
{
    public Id id;
    public UnityEvent matchEvent, noMatchEvent;

    private void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<IDBehavior>();
        if (otherID != null)
        {
            if (otherID.id == id)
            {
                matchEvent.Invoke();
                GetComponent<Collider>().enabled = false;
                Debug.Log("Matched ID: " + id);
            }
            else
            {
                noMatchEvent.Invoke();
                Debug.Log("No Match: " + id);
            }
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}
