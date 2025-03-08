using UnityEngine;

public class SizeOnCollision : MonoBehaviour
{
	void OnCollisionEnter(Collision collision)
	{
		transform.localScale *= Random.Range(0.5F, 2.0F);
	}
}
