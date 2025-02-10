using UnityEngine;

public class RobotController : MonoBehaviour
{
    public RobotMovement robotMovement;  // Link the RobotMovement script

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");  // W/S keys for forward/backward
        float turnInput = Input.GetAxis("Horizontal");  // A/D keys for turning

        robotMovement.MoveRobot(forwardInput);
        robotMovement.TurnRobot(turnInput);
    }
}
