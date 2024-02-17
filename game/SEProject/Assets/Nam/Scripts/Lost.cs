using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lost : State
{
    public Lost(Battle_System battle_system) : base(battle_system)
    {
    }

    public override IEnumerator Start()
    {
        Battle_System.dialogue.text = "You have lost!";
        yield break;
    }
}
