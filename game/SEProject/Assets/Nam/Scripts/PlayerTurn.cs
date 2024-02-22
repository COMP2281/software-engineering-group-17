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

    public override IEnumerator Answer(bool option)
    {
        bool isPlayerDead = false;
        bool isEnemyDead = false;
        if (option)
        {
            isEnemyDead = BattleSystem.enemyUnit.TakeDamage(BattleSystem.playerUnit.damage);
            BattleSystem.enemyHud.SetHp(BattleSystem.enemyUnit.currentHp);
            BattleSystem.dialogue.text = BattleSystem.enemyUnit.unitName + " took damage";
        } 
        else
        {
            isPlayerDead = BattleSystem.playerUnit.TakeDamage(BattleSystem.enemyUnit.damage);
            BattleSystem.playerHud.SetHp(BattleSystem.playerUnit.currentHp);
            BattleSystem.dialogue.text = "You took damage";
        }

        yield return new WaitForSeconds(2f);

        if (isEnemyDead)
        {
            BattleSystem.SetState(new Won(BattleSystem));
        }
        else if (isPlayerDead)
        {
            BattleSystem.SetState(new Lost(BattleSystem));
        }
        else
        {
            BattleSystem.SetState(new EnemyTurn(BattleSystem));
        }
    }
}

