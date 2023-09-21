using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    #region Fields
    [Header("Controls")]
    public float plazerSpeed = 5.0f;
    public float crouchSpeed = 2.0f;
    public float sprintSpeed = 7.0f;
    public float jumpHeight = 0.8f;
    public float gravityMultiplier = 2.0f;
    public float rotationSpeed = 5.0f;
    public float crouchColliderHeight = 1.35f;

    public WalkState walkSM;
    public IdleState idleSM;
    public CrouchState crouchSM;
    public SprintState sprintSM;
    public JumpState jumpSM;
    public SprintJumpState springJumpSM;
    public LandingState landingSM;
    #endregion
}
