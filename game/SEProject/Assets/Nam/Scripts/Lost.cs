using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lost : State
{
    public Lost(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        BattleSystem.dialogue.text = "You have lost!";
        BattleSystem.buttonManager.ClearButtons();
        yield break;
    }
}
