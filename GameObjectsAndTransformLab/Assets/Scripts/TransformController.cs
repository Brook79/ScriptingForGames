using UnityEngine;

public class TransformController : MonoBehaviour
{
    private void Update()
    {
        //move the target GameObject
        var x = Mathf.PingPong(Time.time, 1);
        var p = new Vector3(x, 0, 2 * x);
        transform.position = p;
        
        // Rotate the target GameObject
        transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
    }
}