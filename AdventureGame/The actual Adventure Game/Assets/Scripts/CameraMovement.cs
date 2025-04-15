using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform _thisTransform;
    private void Start()
    {
        _thisTransform = GetComponent<Transform>();
        Vector3 levelone = new Vector3(-89.5f, 0.2f, -13f);
        _thisTransform.position = levelone;
    }

    public void lvlTwo()
    {
        var myspot = _thisTransform.position;
        myspot.x = -55.25f;
        while (_thisTransform.position != myspot)
        {
            _thisTransform.position = Vector3.Lerp(_thisTransform.position, myspot, 5f * Time.deltaTime);
        }
    }
    
    public void lvlThree()
    {
        var myspot = _thisTransform.position;
        myspot.x = -21f;
        while (_thisTransform.position != myspot)
        {
            _thisTransform.position = Vector3.Lerp(_thisTransform.position, myspot, 5f * Time.deltaTime);
        }
    }
    
    public void lvlFour()
    {
        var myspot = _thisTransform.position;
        myspot.x = 14.25f;
        while (_thisTransform.position != myspot)
        {
            _thisTransform.position = Vector3.Lerp(_thisTransform.position, myspot, 5f * Time.deltaTime);
        }
    }
    
    public void lvlFive()
    {
        var myspot = _thisTransform.position;
        myspot.x = 49f;
        while (_thisTransform.position != myspot)
        {
            _thisTransform.position = Vector3.Lerp(_thisTransform.position, myspot, 5f * Time.deltaTime);
        }
    }
    
    public void lvlSix()
    {
        var myspot = _thisTransform.position;
        myspot.x = 82.5f;
        while (_thisTransform.position != myspot)
        {
            _thisTransform.position = Vector3.Lerp(_thisTransform.position, myspot, 5f * Time.deltaTime);
        }
    }
}
