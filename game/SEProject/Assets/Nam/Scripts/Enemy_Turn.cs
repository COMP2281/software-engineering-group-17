using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Turn : State
{
    public Enemy_Turn(Battle_System battle_system) : base(battle_system)
    {
    }

    public override IEnumerator Start()
    {
        // Battle_System.dialogue.text = "Question";
        bool is_dead = Battle_System.player_unit.Take_Damage(Battle_System.enemy_unit.damage);
        Battle_System.player_hud.Set_Hp(Battle_System.player_unit.current_hp);
        Battle_System.dialogue.text = "You took damage";

        yield return new WaitForSeconds(2f);

        if (is_dead)
        {
            Battle_System.Set_State(new Lost(Battle_System));
        }
        else
        {
            Battle_System.Set_State(new Player_Turn(Battle_System));
        }
    }
}
