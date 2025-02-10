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
        
        // Get player input for turning
        float turnInput = Input.GetAxis("Horizontal");  // A/D or Left/Right arrows
        TurnRobot(turnInput);
    }

    public void MoveRobot(float moveInput)
    {
        if (Mathf.Abs(moveInput) > 0.1f) // Apply movement only if significant input
        {
            frontLeftWheel.motorTorque = motorTorque * moveInput;
            frontRightWheel.motorTorque = motorTorque * moveInput;
            backLeftWheel.motorTorque = motorTorque * moveInput;
            backRightWheel.motorTorque = motorTorque * moveInput;
            
            // Remove brake force
            frontLeftWheel.brakeTorque = 0f;
            frontRightWheel.brakeTorque = 0f;
            backLeftWheel.brakeTorque = 0f;
            backRightWheel.brakeTorque = 0f;
        }
        else
        {
            // Apply braking force when no input
            frontLeftWheel.brakeTorque = 100f;
            frontRightWheel.brakeTorque = 100f;
            backLeftWheel.brakeTorque = 100f;
            backRightWheel.brakeTorque = 100f;
        }
    }

    public void TurnRobot(float turnInput)
    {
        frontLeftWheel.steerAngle = 30f * turnInput;
        frontRightWheel.steerAngle = 30f * turnInput;
    }
}
