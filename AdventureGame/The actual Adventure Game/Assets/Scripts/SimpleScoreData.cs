using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleIntData : MonoBehaviour
{
	public int value;
	
	public void UpdateValue(int amount)
	{
		value += amount;
		Debug.Log("Point!");
	}
	
	public void SetValue(int amount)
	{
		value = amount;
	}
} 