using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    #region Fields
    [Header("Controls")]
    public float playerSpeed = 5.0f;
    public float crouchSpeed = 2.0f;
    public float sprintSpeed = 7.0f;
    public float jumpHeight = 0.8f;
    public float gravityMultiplier = 2.0f;
    public float rotationSpeed = 5.0f;
    public float crouchColliderHeight = 1.35f;

    public float gravityValue = -9.81f;
    public PlayerInput playerInput;
    public CharacterController controller;
    #endregion
}
