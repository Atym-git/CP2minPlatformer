using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AxeGoingLeftNRight : MonoBehaviour
{
    [SerializeField] private Transform axeAnchor;

    private int _axeDirection = 1;


    private void FixedUpdate()
    {
        //Debug.Log(axeAnchor.rotation.z);
        if (axeAnchor.rotation.z <= -0.6)
        {
            _axeDirection = 1;
        }
        else if (axeAnchor.rotation.z > 0.6)
        {
            _axeDirection = -1;
        }
        
        axeAnchor.transform.Rotate(0, 0, 1.05f * _axeDirection, Space.World);
    }
}
