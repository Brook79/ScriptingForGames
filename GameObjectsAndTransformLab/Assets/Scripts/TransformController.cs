using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        //move the target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(x, x, x);
        transform.position = p;
        
        // Rotate the target GameObject
        transform.Rotate(new Vector3(15, 20, 10) * Time.deltaTime);
    }
}