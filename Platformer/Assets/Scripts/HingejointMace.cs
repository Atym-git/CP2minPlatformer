using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HingejointMace : MonoBehaviour
{
    [SerializeField] private HingeJoint2D maceHingeJoint2D;
    [SerializeField] private float speed;
    [SerializeField] private Transform maceMaxPosition;

    private void Awake()
    {
        JointMotor2D motor = maceHingeJoint2D.motor;
        motor.motorSpeed = speed;
        maceHingeJoint2D.motor = motor;
    }
}
