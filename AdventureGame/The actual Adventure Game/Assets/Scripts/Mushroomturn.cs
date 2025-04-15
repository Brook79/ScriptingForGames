using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroomturn : MonoBehaviour
{
    public float direction1 = 0, direction2 = 180;

    public void turntoRight()
    {
        transform.rotation = Quaternion.Euler(0, direction2, 0);
    }

    public void turntoLeft()
    {
        transform.rotation = Quaternion.Euler(0, direction1, 0);
    }
}
