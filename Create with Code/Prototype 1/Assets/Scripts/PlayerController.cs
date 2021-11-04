using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnSpeed = 900.0f;
    private float horizontalInput;
    private float forwardInput;
    public float turningAngle = 0.0f;
    public float maxAngle;

    public GameObject leftWheel;
    public GameObject rightWheel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We turning wheels
        float angleDelta = Time.deltaTime * turnSpeed * horizontalInput;
        float newAngle = turningAngle + angleDelta;

        if (newAngle >= maxAngle) {
            angleDelta = maxAngle - turningAngle;
        } else if (newAngle <= -maxAngle)
        {
            angleDelta = -maxAngle - turningAngle;
        }
        
        turningAngle += angleDelta;
        leftWheel.transform.Rotate(leftWheel.transform.up, angleDelta * 0.15f);
        rightWheel.transform.Rotate(leftWheel.transform.up, angleDelta * 0.15f);


        // We move the vehicle forward and turning it, while rotating wheels back
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        float rotateAngle = Time.deltaTime * turningAngle * forwardInput;
        transform.Rotate(Vector3.up, rotateAngle);

        
    }
}
