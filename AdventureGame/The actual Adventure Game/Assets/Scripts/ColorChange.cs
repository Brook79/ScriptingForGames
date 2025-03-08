using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorRandomize : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		GetComponent<Renderer>().material.color = Random.ColorHSV();
	}
}
