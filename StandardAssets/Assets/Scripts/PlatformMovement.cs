using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public KeyCode keyUp;
    public KeyCode keyDown;
    public KeyCode keyLeft;
    public KeyCode KeyRight;
    public Vector3 center;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(keyLeft))
        {
            transform.RotateAround(center, Vector3.forward, 20 * Time.deltaTime);
        }
        if (Input.GetKey(KeyRight))
        {
            transform.RotateAround(center, -Vector3.forward, 20 * Time.deltaTime);
        }

        if (Input.GetKey(keyUp))
        {
            transform.RotateAround(center, Vector3.right, 20 * Time.deltaTime);
        }

        if (Input.GetKey(keyDown))
        {
            transform.RotateAround(center, Vector3.left, 20 * Time.deltaTime);
        }
    }
}
