using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Attack状态
/// </summary>
public class AttackState : StateTemplate<Player>
{

    public AttackState(int id, Player p) : base(id, p)
    {
    }

    public override void OnEnter(params object[] args)
    {
        base.OnEnter(args);
        owner.statetxt.text = "attack";
    }
    public override void OnStay(params object[] args)
    {
        base.OnStay(args);
        if (owner.statetxt.text != "attack")
        {
            OnExit();
        }
    }
    public override void OnExit(params object[] args)
    {
        base.OnExit(args);
        owner.ps = PlayerState.Idle;
    }
}