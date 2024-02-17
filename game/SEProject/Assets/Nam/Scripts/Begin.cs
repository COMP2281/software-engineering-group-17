using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Begin : State
{
    public Begin(Battle_System battle_System) : base(battle_System)
    {
    }
    public override IEnumerator Start()
    {
        GameObject player_go = Battle_System.Instantiate(Battle_System.player_prehab, Battle_System.player_battlestation);
        Battle_System.player_unit = player_go.GetComponent<Combat_Unit>();

        GameObject enemy_go = Battle_System.Instantiate(Battle_System.enemy_prehab, Battle_System.enemy_battlestation);
        Battle_System.enemy_unit = enemy_go.GetComponent<Combat_Unit>();

        Battle_System.dialogue.text = "Question Question Question Question";

        Battle_System.player_hud.Set_Hud(Battle_System.player_unit);
        Battle_System.enemy_hud.Set_Hud(Battle_System.enemy_unit);

        yield return new WaitForSeconds(2f);

        Battle_System.Set_State(new Player_Turn(Battle_System));
    }
}
