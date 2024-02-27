using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTurn : State
{
    public PlayerTurn(BattleSystem BattleSystem) : base(BattleSystem)
    {
    }

    public override IEnumerator Start()
    {
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
            BattleSystem.dialogue.text = "Correct, " + BattleSystem.enemyUnit.unitName + " took " + BattleSystem.playerUnit.damage + " HP";
            
            BattleSystem.playerPrefab.gameObject.transform.GetChild(0).gameObject.SetActive(true);
            BattleSystem.playerPrefab.gameObject.transform.GetChild(2).gameObject.SetActive(false);

            BattleSystem.enemyPrefab.gameObject.transform.GetChild(2).gameObject.SetActive(false);
            BattleSystem.enemyPrefab.gameObject.transform.GetChild(1).gameObject.SetActive(true);

        } 
        else
        {
            isPlayerDead = BattleSystem.playerUnit.TakeDamage(BattleSystem.enemyUnit.damage);
            BattleSystem.playerHud.SetHp(BattleSystem.playerUnit.currentHp);
            BattleSystem.dialogue.text = "Incorrect, you lost " + BattleSystem.enemyUnit.damage + " HP";

            BattleSystem.playerPrefab.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            BattleSystem.playerPrefab.gameObject.transform.GetChild(2).gameObject.SetActive(false);

            BattleSystem.enemyPrefab.gameObject.transform.GetChild(2).gameObject.SetActive(false);
            BattleSystem.enemyPrefab.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }

        yield return new WaitForSeconds(5);
        for (int i = 0; i < 2; i++)
        {
            BattleSystem.playerPrefab.gameObject.transform.GetChild(i).gameObject.SetActive(false);
            BattleSystem.enemyPrefab.gameObject.transform.GetChild(i).gameObject.SetActive(false);
        }
        BattleSystem.playerPrefab.gameObject.transform.GetChild(2).gameObject.SetActive(true);
        BattleSystem.enemyPrefab.gameObject.transform.GetChild(2).gameObject.SetActive(true);

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

