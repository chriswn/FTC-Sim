using UnityEngine;

public class DistanceSensor : MonoBehaviour
{
    public float sensorRange = 5.0f;
    public Transform sensorPosition;

    void Update()
    {
        RaycastHit hit;
        // Cast a ray from the sensor position in the forward direction
        if (Physics.Raycast(sensorPosition.position, sensorPosition.forward, out hit, sensorRange))
        {
            Debug.Log("Obstacle detected at: " + hit.distance + " meters");
        }
        else
        {
            Debug.Log("No obstacle detected.");
        }
    }
}
