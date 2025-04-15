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
	public void setHealth(float amount)
	{
		healthValue.SetValue(amount);
	}
	private void Update()
	{
		if (healthValue.value <= 0)
		{
			Time.timeScale = 0;
		}
	}
}
