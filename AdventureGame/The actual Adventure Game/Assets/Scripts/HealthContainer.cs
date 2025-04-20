using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData healthValue;
	public UnityEvent youDied;

	private void Update()
	{
		if (healthValue.value <= 0)
		{
			adjustHealth(1f);
			youDied.Invoke();
		}
	}
	
    public void adjustHealth(float amount) 
    {
        healthValue.UpdateValue(amount);
    }
	public void setHealth(float amount)
	{
		healthValue.SetValue(amount);
	}
}
