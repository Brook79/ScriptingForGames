using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaContainer : MonoBehaviour
{
    public SimpleFloatData staminaValue;

	private void Start()
	{
		staminaValue.SetValue(1);
	}

    public void adjustStamina(float amount)
    {
        staminaValue.UpdateValue(amount);
        if (staminaValue.value > 1)
        {
            staminaValue.SetValue(1);
        }
    }
}