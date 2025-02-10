using UnityEngine;

public class RobotController : MonoBehaviour
{
    public RobotMovement robotMovement;  // Link the RobotMovement script

    void Update()
    {
        // Check for player input (W/S keys for movement)
        if (Input.GetKey(KeyCode.W))  // Move forward (W key)
        {
            robotMovement.MoveRobot(1);  // Move forward
        }
        else if (Input.GetKey(KeyCode.S))  // Move backward (S key)
        {
            robotMovement.MoveRobot(-1);  // Move backward
        }
        else
        {
            robotMovement.MoveRobot(0);  // Stop the robot if no input
        }
    }
}
