using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// PlayerCtrl
/// 挂载在角色身上的脚本，用来控制状态机器类
/// </summary>
/// 
public enum PlayerState
{
    None,
    Idle,
    Run,
    Attack,
    right,
    left,
    up,
    down
}

public class Player : MonoBehaviour
{

    //public Animation ani;
    public Text statetxt;
    public PlayerState ps = PlayerState.Idle;

    //控制机器
    public StateMachine machine;

    void Start()
    {
        //ani = GetComponent<Animation>();

        IdleState idle = new IdleState(1, this);
        LeftState left = new LeftState(2, this);
        RightState right = new RightState(3, this);
        UpState up = new UpState(4, this);
        DownState down = new DownState(5, this);
        AttackState attack = new AttackState(6, this);

        machine = new StateMachine(idle);
        machine.AddState(left);
        machine.AddState(right);
        machine.AddState(up);
        machine.AddState(down);
        machine.AddState(attack);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ps = PlayerState.Attack;
        }
        if (Input.GetKey(KeyCode.A))
        {
            ps = PlayerState.left;
            Debug.Log("inputget");
        }
        if (Input.GetKey(KeyCode.D))
        {
            ps = PlayerState.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            ps = PlayerState.up;
        }
        if (Input.GetKey(KeyCode.S))
        {
            ps = PlayerState.down;
        }

        //根据枚举 让状态机器类去切换状态
        UpdateAnimation();
    }
    private void UpdateAnimation()
    {
        switch (ps)
        {
            case PlayerState.Idle:
                machine.TranslateState(1);
                break;
            case PlayerState.left:
                machine.TranslateState(2);
                Debug.Log("machinedid");
                break;
            case PlayerState.right:
                machine.TranslateState(3);
                break;
            case PlayerState.up:
                machine.TranslateState(4);
                break;
            case PlayerState.down:
                machine.TranslateState(5);
                break;
            case PlayerState.Attack:
                machine.TranslateState(6);
                break;

        }
    }

    void LateUpdate()
    {
        machine.Update();
    }
}