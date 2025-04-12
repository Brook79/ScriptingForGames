using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Banaanimator : MonoBehaviour
{
    public UnityEvent triggerEvent;
    
    private Animator animator;
    private float _timerThing; 
	
    private void Start()
    {
        animator = GetComponent<Animator>();
		_timerThing = 0;
    }
	
	private void Update()
	{
		if (_timerThing < Time.time)
		{
			animator.SetTrigger("idle");
		}
	}

    private void OnTriggerEnter(Collider other)
    {
        float xvalue = Random.Range(-4.5f, 4.5f);
        float yvalue = Random.Range(0, 5);
        triggerEvent.Invoke();
        animator.SetTrigger("dissappear");
        Vector3 newPosition = new Vector3(xvalue, yvalue, transform.position.z);
        transform.position = newPosition;
        _timerThing = Time.time + 0.25f;
    }
}