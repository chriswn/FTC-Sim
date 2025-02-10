using UnityEngine;

public class DistanceSensor : MonoBehaviour
{
    public float sensorRange = 5.0f;
    public Transform sensorPosition;
    public LayerMask obstacleLayer; // Filter for detecting only relevant objects

    public bool isObstacleDetected;
    public float detectedDistance;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(sensorPosition.position, sensorPosition.forward, out hit, sensorRange, obstacleLayer))
        {
            isObstacleDetected = true;
            detectedDistance = hit.distance;
        }
        else
        {
            isObstacleDetected = false;
            detectedDistance = sensorRange;
        }
    }
}
