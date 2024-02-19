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
        // BattleSystem.dialogue.text = "Question";
        bool is_dead = BattleSystem.playerUnit.TakeDamage(BattleSystem.enemyUnit.damage);
        BattleSystem.playerHud.SetHp(BattleSystem.playerUnit.currentHp);
        BattleSystem.dialogue.text = "You took damage";

        yield return new WaitForSeconds(2f);

        if (is_dead)
        {
            BattleSystem.SetState(new Lost(BattleSystem));
        }
        else
        {
            BattleSystem.SetState(new PlayerTurn(BattleSystem));
        }
    }
}
