﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Run状态
/// </summary>

public class DownState : StateTemplate<Player>
{

    public DownState(int id, Player p) : base(id, p)
    {
    }

    public override void OnEnter(params object[] args)
    {
        base.OnEnter(args);
        owner.statetxt.text = "Down";
    }
    public override void OnStay(params object[] args)
    {
        base.OnStay(args);
    }
    public override void OnExit(params object[] args)
    {
        base.OnExit(args);
    }
}
