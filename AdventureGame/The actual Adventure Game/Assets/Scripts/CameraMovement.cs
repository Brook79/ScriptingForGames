using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform _thisTransform;
    private void Start()
    {
        _thisTransform = GetComponent<Transform>();
        Vector3 levelone = new Vector3(-89.5f, 0.2f, -20f);
        _thisTransform.position = levelone;
    }

    public void lvlOne()
    {
        var myspot = _thisTransform.position;
        myspot.x = -89.5f;
        _thisTransform.position = myspot;
    }
    

    public void lvlTwo()
    {
        var myspot = _thisTransform.position;
        myspot.x = -55.5f;
        _thisTransform.position = myspot;
    }
    
    public void lvlThree()
    {
        var myspot = _thisTransform.position;
        myspot.x = -21f;
        _thisTransform.position = myspot;
    }
    
    public void lvlFour()
    {
        var myspot = _thisTransform.position;
        myspot.x = 14.25f;
        _thisTransform.position = myspot;
    }
    
    public void lvlFive()
    {
        var myspot = _thisTransform.position;
        myspot.x = 49f;
        _thisTransform.position = myspot;
    }
    
    public void lvlSix()
    {
        var myspot = _thisTransform.position;
        myspot.x = 82.5f;
        _thisTransform.position = myspot;
    }
}
