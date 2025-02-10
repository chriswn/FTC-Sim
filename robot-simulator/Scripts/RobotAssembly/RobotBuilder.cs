using System.Collections.Generic;
using UnityEngine;

// Robot Builder - Handles Drag & Drop System
public class RobotBuilder : MonoBehaviour
{
    public Transform chassis;
    public List<GameObject> availableParts;
    public GameObject selectedPart;
    
    public void AttachPart(GameObject part)
    {
        if (selectedPart != null)
        {
            Instantiate(part, chassis.position, Quaternion.identity, chassis);
        }
    }
}
