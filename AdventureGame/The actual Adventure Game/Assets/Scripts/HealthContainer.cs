using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthContainer : MonoBehaviour
{
    public SimpleFloatData healthValue;
	public UnityEvent youDied;
	private float _deathTime;

	private void Start()
	{
		_deathTime = 0;
	}

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
			_deathTime = Time.time + 0.5f;
			youDied.Invoke();
		}

		if (_deathTime <= Time.time && _deathTime !=0)
		{
			Time.timeScale = 0;
		}
	}
}
