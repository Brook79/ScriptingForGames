using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StaminaContainer : MonoBehaviour
{
    public SimpleFloatData staminaValue;
    public UnityEvent thisevent;
    public UnityEvent otherevent;

    public void adjustStamina(float amount)
    {
        staminaValue.UpdateValue(amount);
        if (staminaValue.value > 1)
        {
            staminaValue.SetValue(1);
        }
    }

    public void setStamina(float amount)
    {
        staminaValue.SetValue(amount);
    }

    private void Update()
    {
        if (staminaValue.value <= 0)
        {
            thisevent.Invoke();
        }
        else
        {
            otherevent.Invoke();
        }
    }
}