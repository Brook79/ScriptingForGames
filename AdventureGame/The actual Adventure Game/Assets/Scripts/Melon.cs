using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Melon : MonoBehaviour
{
    public UnityEvent levelComplete;
    public UnityEvent levelSwitch;
    
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
        levelComplete.Invoke();
        animator.SetTrigger("dissappear");
        _dissappearTime = Time.time + 0.2f;
    }

    private void Update()
    {
        if (_dissappearTime <= Time.time && _dissappearTime != 0)
        {
            levelSwitch.Invoke();
            Destroy(gameObject);
        }
    }
}
