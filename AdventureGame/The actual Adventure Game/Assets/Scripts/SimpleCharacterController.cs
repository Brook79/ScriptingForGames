using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
	public float moveSpeed = 5f;
	public float jumpForce = 8f;
	public float gravity = -9.81f;
	private CharacterController _controller;
	private Vector3 _velocity;
	private Transform _thisTransform;
	
	
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
	}
	
	private void MoveCharacter()
	{
		var moveInput = Input.GetAxis("Horizontal");
		var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
		_controller.Move(move);

		if (Input.GetButtonDown("Jump"))
		{
			_velocity.y = Mathf.Sqrt(jumpForce * -1/2 * gravity);
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
}