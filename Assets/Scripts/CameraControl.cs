using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public KeyCode moveForward;
    public KeyCode moveBackward;
    public KeyCode rotateRight;
    public KeyCode rotateLeft;
    public KeyCode moveUp;
    public KeyCode moveDown;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetKeyInputs();
    }

    public void GetKeyInputs()
    {
        if (Input.GetKeyDown(rotateLeft))
        {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, -.5f, 0);
        }

        if (Input.GetKeyUp(rotateLeft))
        {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(rotateRight))
        {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, .5f, 0);
        }

        if (Input.GetKeyUp(rotateRight))
        {
            GetComponent<Rigidbody>().angularVelocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(moveForward))
        {
            GetComponent<Rigidbody>().AddRelativeForce(0, 0, 100);
        }

        if (Input.GetKeyUp(moveForward))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(moveBackward))
        {
            GetComponent<Rigidbody>().AddRelativeForce(0, 0, -100);
        }

        if (Input.GetKeyUp(moveBackward))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(moveUp))
        {
            GetComponent<Rigidbody>().AddRelativeForce(0, 100, 0);
        }

        if (Input.GetKeyUp(moveUp))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyDown(moveDown))
        {
            GetComponent<Rigidbody>().AddRelativeForce(0, -100, 0);
        }

        if (Input.GetKeyUp(moveDown))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        }
    }
}
