using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begin : State
{
    public Begin(BattleSystem battleSystem) : base(battleSystem)
    {
    }
    public override IEnumerator Start()
    {
        GameObject playerGo = Object.Instantiate(BattleSystem.playerPrefab);
        BattleSystem.playerUnit = playerGo.GetComponent<CombatUnit>();
        BattleSystem.playerUnit.currentHp = GM.gmInstance.GetHP();
        BattleSystem.playerUnit.damage = GM.gmInstance.GetAttackDamage();

        GameObject enemyGo = Object.Instantiate(BattleSystem.enemyPrefab);
        BattleSystem.enemyUnit = enemyGo.GetComponent<CombatUnit>();

        BattleSystem.dialogue.text = "You are about to fight " + BattleSystem.enemyUnit.unitName + " !!!";

        BattleSystem.playerHud.SetHud(BattleSystem.playerUnit);
        BattleSystem.enemyHud.SetHud(BattleSystem.enemyUnit);

        yield return new WaitForSeconds(11f);

        BattleSystem.SetState(new EnemyTurn(BattleSystem));
    }
}
