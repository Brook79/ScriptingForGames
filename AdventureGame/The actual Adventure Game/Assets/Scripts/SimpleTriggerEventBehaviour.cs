using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        //Triggers the event and tests with a debug message
        triggerEvent.Invoke();
        Debug.Log("Player interacted with the object!");
    }
}
