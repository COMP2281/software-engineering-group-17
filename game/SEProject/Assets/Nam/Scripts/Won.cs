using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Won : State
{
    public Won(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        BattleSystem.dialogue.text = "You have won!";
        BattleSystem.buttonManager.ClearButtons();
        yield break;
    }
}
