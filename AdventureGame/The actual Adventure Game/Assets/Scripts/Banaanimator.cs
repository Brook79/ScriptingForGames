using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Banaanimator : MonoBehaviour
{
    public UnityEvent triggerEvent;
    
    private Animator animator;
	private float _dissappearTime;
	
    private void Start()
    {
		_dissappearTime = 0;
        animator = GetComponent<Animator>();
		animator.SetTrigger("idle");
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
        animator.SetTrigger("dissappear");
		_dissappearTime = Time.time + 0.2f;
    }
	private void Update()
	{
		if (_dissappearTime <= Time.time && _dissappearTime != 0)
		{
			Destroy(gameObject);
		}
	}
}