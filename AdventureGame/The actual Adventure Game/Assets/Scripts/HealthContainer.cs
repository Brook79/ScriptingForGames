using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData healthValue;

    public void adjustHealth(float amount) 
    {
        healthValue.UpdateValue(amount);
    }
}
