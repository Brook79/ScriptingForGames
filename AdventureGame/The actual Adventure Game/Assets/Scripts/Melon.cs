using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Melon : MonoBehaviour
{
    public UnityEvent levelComplete;
    public UnityEvent levelSwitch;
    private float _dissappearTime;

    private void OnTriggerEnter(Collider other)
    {
        levelComplete.Invoke();
        levelSwitch.Invoke();
    }
}