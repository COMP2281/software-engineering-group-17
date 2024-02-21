using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurn : State
{
    public PlayerTurn(BattleSystem BattleSystem) : base(BattleSystem)
    {
    }

    public override IEnumerator Start()
    {
        BattleSystem.dialogue.text = "User action User action User action User action";
        yield break;
    }

    public override IEnumerator Attack()
    {
        bool is_dead = BattleSystem.enemyUnit.TakeDamage(BattleSystem.playerUnit.damage);
        BattleSystem.enemyHud.SetHp(BattleSystem.enemyUnit.currentHp);
        BattleSystem.dialogue.text = "The enemy took damage";

        yield return new WaitForSeconds(2f);

        if (is_dead)
        {
            BattleSystem.SetState(new Won(BattleSystem));
        }
        else
        {
            BattleSystem.SetState(new EnemyTurn(BattleSystem));
        }
    }
}

