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
	public UnityEvent triggerActionEvent;
	public bool canMove;
	private int _canDoubleJump;
	private bool _reachedCheckpoint;
	public UnityEvent cameraReset;
	public UnityEvent cameracheckpoint;

	public float X;
	public float Y;
	
	private void Start()
	{
		_controller = GetComponent<CharacterController>();
		_thisTransform = GetComponent<Transform>();
		canMove = true;
		_canDoubleJump = 0;
		_reachedCheckpoint = false;
	}
	
	private void Update()
	{
		if (canMove)
		{
			MoveCharacter();
		}
		else
		{
			triggerActionEvent.Invoke();
		}
		ApplyGravity();
		KeepCharacterOnXAxis();
		IdleStaminaIncrease();
		X = _thisTransform.position.x;
		Y = _thisTransform.position.y;
	}

	public void Nomove()
	{
		canMove = false;
	}

	public void Checkpoint()
	{
		_reachedCheckpoint = true;
	}

	public void DeathResult()
	{
		if (_reachedCheckpoint)
		{
			_controller.enabled = false;
			_thisTransform.position = new Vector3(0, -2.34f, 0);
			cameracheckpoint.Invoke();
			Debug.Log("DeathResult.check");
			_controller.enabled = true;
		}
		else
		{
			_controller.enabled = false;
			_thisTransform.position = new Vector3(-101, -4, 0);
			cameraReset.Invoke();
			Debug.Log("DeathResult.nocheck");
			_controller.enabled = true;
		}
	}

	public void Moveagain()
	{
		canMove = true;
	}
	
	private void MoveCharacter()
	{
		var moveInput = Input.GetAxis("Horizontal");
		var isMoving = moveInput != 0;
		var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
		_controller.Move(move);

		if (Input.GetButtonDown("Jump") && _canDoubleJump < 2)
		{
			_velocity.y = Mathf.Sqrt(jumpForce * -1/2 * gravity);
			isMoving = true;
			_canDoubleJump++;
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
			_canDoubleJump = 0;
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
			_staminaCooldown = Time.time + 0.5f;
		}
	}
}