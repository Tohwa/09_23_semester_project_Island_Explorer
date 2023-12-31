using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class Player : MonoBehaviour
{
    #region Fields
    public StateMachine StateMachine { get; private set; }

    public PlayerIdleState IdleState { get; private set; }
    public PlayerMoveState MoveState { get; private set; }

    public PlayerInputHandler InputHandler { get; private set; }

    public Animator Anim { get; private set; }

    public Rigidbody RB { get; private set; }

    [SerializeField]
    private PlayerData playerData;
    [SerializeField]
    private SoundRequestCollection requests;
    [SerializeField]
    private AudioData footSteps;
    #endregion

    private void Awake()
    {
        StateMachine = new StateMachine();

        IdleState = new PlayerIdleState(this, StateMachine, playerData);
        MoveState = new PlayerMoveState(this, StateMachine, playerData);
    }

    private void Start()
    {
        Anim = GetComponent<Animator>();
        InputHandler = GetComponent<PlayerInputHandler>();
        RB = GetComponent<Rigidbody>();

        StateMachine.InitPlayerState(IdleState);
    }

    private void Update()
    {
        StateMachine.curPlayerState.LogicUpdate();

        if (StateMachine.curPlayerState == MoveState)
        {
            if (Time.frameCount % 60 == 0)
            {
                requests.Add(SoundRequest.Request(footSteps));
            }
        }
    }

    private void FixedUpdate()
    {
        StateMachine.curPlayerState.PhysicsUpdate();
    }

    public void MovePlayer(float inputX, float inputY)
    {
        Vector3 movement = new Vector3(inputX, 0f, inputY) * playerData.moveSpeed * Time.deltaTime;
        movement = Quaternion.Euler(0, Camera.main.transform.eulerAngles.y, 0) * movement;
        movement = Vector3.ClampMagnitude(movement, 1) * 3;
        RB.MovePosition(transform.position + transform.TransformDirection(movement));
    }
}
