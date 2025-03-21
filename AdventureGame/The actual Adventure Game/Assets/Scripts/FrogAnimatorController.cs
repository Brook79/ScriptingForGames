using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;
	
	private void Start()
	{
		animator = GetComponent<Animator>();
	}
	
	private void Update()
	{
		HandleAnimations();
	}
	
	private void HandleAnimations()
	{
		//triggers the Jump animation
		if (Input.GetButtonDown("Jump"))
		{
			animator.SetTrigger("Jump");
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
		if (Input.GetAxis("Horizontal") != 0)
		{
			animator.SetTrigger("Run");
		}
		else
		{
			animator.SetTrigger("idle");
		}
		
		//triggers the Run Animation
		if (Input.GetKeyDown(KeyCode.W))
		{
			animator.SetTrigger("WJ");
		}
		else
		{
			animator.SetTrigger("idle");
		}
		//triggers the Double Jump Animation
		if (Input.GetKeyDown(KeyCode.T))
		{
			animator.SetTrigger("DJ");
		}
		else
		{
			animator.SetTrigger("idle");
		}
	}
}
