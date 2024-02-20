using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTurn : State
{
    public EnemyTurn(BattleSystem battleSystem) : base(battleSystem)
    {
    }

    public override IEnumerator Start()
    {
        BattleSystem.askedQuestion.SetQuestion("Are you dead", 1);
        yield return new WaitForSeconds(2f);
        BattleSystem.SetState(new PlayerTurn(BattleSystem));
    }
}
