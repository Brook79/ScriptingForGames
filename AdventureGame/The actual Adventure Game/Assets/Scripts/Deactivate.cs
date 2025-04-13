using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deactivate : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Rigidbody>().isKinematic = false;
    }
    public void deactivate()
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
