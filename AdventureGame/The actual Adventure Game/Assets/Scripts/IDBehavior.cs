using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IDBehavior : MonoBehaviour
{
    public Id id;
	public UnityEvent OnReset;

    void Start()
    {
        OnReset.Invoke();
    }
}
