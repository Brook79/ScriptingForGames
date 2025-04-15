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
				BoxCollider[] boxColliders = GetComponents<BoxCollider>();
				foreach (BoxCollider collider in boxColliders)
				{
					collider.enabled = false;
				}
			}
            else
            {
                noMatchEvent.Invoke();
            }
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}
