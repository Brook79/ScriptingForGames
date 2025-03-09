using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
	
	void Start()
	{
		animator = GetComponent<Animator>();
	}
	
	void Update()
	{
		HandleAnimations();
	}
	
	private void HandleAnimations()
	{
		//triggers the Double Jump animation
		if (Input.GetButtonDown("Jump"))
		{
			animator.SetTrigger("DJ");
		}
		else
		{ 
			animator.SetTrigger("idle");
		}
		
		//triggers the Hit Animation
		if (Input.GetKeyDown(KeyCode.H))
		{
			animator.SetTrigger("Hit");
		}
		else
		{
			animator.SetTrigger("idle");
		}
		
		//triggers the Fall Animation
		if (Input.GetKeyDown(KeyCode.F))
		{
			animator.SetTrigger("Fall");
		}
		else
		{
			animator.SetTrigger("idle");
		}
		
		//triggers the Run Animation
		if (Input.GetKeyDown(KeyCode.A))
		{
			animator.SetTrigger("Run");
		}
		else
		{
			animator.SetTrigger("idle");
		}
		
		//triggers the Run Animation
		if (Input.GetKey(KeyCode.D))
		{
			animator.SetTrigger("Run");
		}
		else
		{
			animator.SetTrigger("idle");
		}
	}
}
