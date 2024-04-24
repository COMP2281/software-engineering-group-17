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
        BattleSystem.questionManager.Generate();
        yield return new WaitForSeconds(0);
        BattleSystem.SetState(new PlayerTurn(BattleSystem));
    }
}
