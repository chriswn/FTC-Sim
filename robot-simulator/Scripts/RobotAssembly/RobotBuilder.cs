using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobotBuilder : MonoBehaviour
{
    public Transform chassis;
    public List<GameObject> availableParts;
    public GameObject selectedPart;
    
    public void AttachPart(GameObject part)
    {
        if (selectedPart != null)
        {
            GameObject newPart = Instantiate(part, chassis.position, Quaternion.identity, chassis);
            newPart.AddComponent<Rigidbody>();  // Add physics to simulate real-world weight
        }
    }
}
