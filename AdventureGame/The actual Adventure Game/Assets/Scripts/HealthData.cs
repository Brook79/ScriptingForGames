using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
    public float value;

	private void Start()
	{
		SetValue(1);
	}

    public void UpdateValue(float amount)
    {
        value += amount;
    }

    public void SetValue(float amount)
    {
        value = amount;
    }
}