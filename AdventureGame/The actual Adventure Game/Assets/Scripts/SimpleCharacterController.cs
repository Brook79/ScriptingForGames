using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
	public float moveSpeed = 5f;
	public float jumpForce = 8f;
	public float gravity = -9.81f;
	private CharacterController _controller;
	private Vector3 _velocity;
	private Transform _thisTransform;
	private float _staminaCooldown;
	public UnityEvent triggerEvent;
	public UnityEvent triggerOtherEvent;
	private float _pushPower = 2f;
	
	
	private void Start()
	{
		_controller = GetComponent<CharacterController>();
		_thisTransform = transform;
	}
	
	private void Update()
	{
		MoveCharacter();
		ApplyGravity();
		KeepCharacterOnXAxis();
		IdleStaminaIncrease();
	}
	
	private void MoveCharacter()
	{
		var moveInput = Input.GetAxis("Horizontal");
		var isMoving = moveInput != 0;
		var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
		_controller.Move(move);

		if (Input.GetButtonDown("Jump"))
		{
			_velocity.y = Mathf.Sqrt(jumpForce * -1/2 * gravity);
			isMoving = true;
		}

		if (isMoving)
		{
			triggerOtherEvent.Invoke();
			_staminaCooldown = Time.time + 1;
		}
	}   

	private void ApplyGravity()
	{
		if (!_controller.isGrounded)
		{
			_velocity.y += gravity * Time.deltaTime;
		}
		else
		{
			_velocity.y = 0f;
		}

		_controller.Move(_velocity * Time.deltaTime);
	}
	
	private void KeepCharacterOnXAxis()
	{
		var currentPosition = _thisTransform.position;
		currentPosition.z = 0f;
		_thisTransform.position = currentPosition;
	}

	private void IdleStaminaIncrease()
	{
		if (Time.time > _staminaCooldown)
		{
			triggerEvent.Invoke();
			_staminaCooldown = Time.time + 1;
		}
	}
}