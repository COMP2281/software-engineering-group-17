using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected Battle_System Battle_System;

    public State(Battle_System battle_system)
    {
        Battle_System = battle_system;
    }

    public virtual IEnumerator Start()
    {
        yield break;
    }
    public virtual IEnumerator Attack()
    {
        yield break;
    }
}
