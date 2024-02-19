using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Won : State
{
    public Won(Battle_System battle_system) : base(battle_system)
    {
    }

    public override IEnumerator Start()
    {
        Battle_System.dialogue.text = "You have won!";
        yield break;
    }
}
