using UnityEngine;

public class RobotMovement : MonoBehaviour
{
    public WheelCollider frontLeftWheel;
    public WheelCollider frontRightWheel;
    public WheelCollider backLeftWheel;
    public WheelCollider backRightWheel;

    public float motorTorque = 150f;
    public float maxSpeed = 10f;

    void Update()
    {
        // Get player input for forward/backward movement
        float moveInput = Input.GetAxis("Vertical");  // W/S or Up/Down arrows
        MoveRobot(moveInput);
    }

    void MoveRobot(float moveInput)
    {
        // Apply torque to each wheel collider
        frontLeftWheel.motorTorque = motorTorque * moveInput;
        frontRightWheel.motorTorque = motorTorque * moveInput;
        backLeftWheel.motorTorque = motorTorque * moveInput;
        backRightWheel.motorTorque = motorTorque * moveInput;

        // Optional: Limit the maximum speed of the robot
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }
    }
}
