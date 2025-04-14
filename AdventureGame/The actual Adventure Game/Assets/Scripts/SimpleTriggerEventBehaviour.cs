using UnityEngine;
using UnityEngine.Events;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            triggerEvent.Invoke();
        }
    }
}
