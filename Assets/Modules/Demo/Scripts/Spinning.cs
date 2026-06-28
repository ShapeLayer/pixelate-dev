using UnityEngine;

public class Spinning : MonoBehaviour
{
    static Vector3 rotateDirection = new Vector3(1, 1, 1); 
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateDirection, 20 * Time.deltaTime);
    }
}
