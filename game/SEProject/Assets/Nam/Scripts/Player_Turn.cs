using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Turn : State
{
    public Player_Turn(Battle_System battle_system) : base(battle_system)
    {
    }

    public override IEnumerator Start()
    {
        Battle_System.dialogue.text = "User action User action User action User action";
        yield break;
    }

    public override IEnumerator Attack()
    {
        bool is_dead = Battle_System.enemy_unit.Take_Damage(Battle_System.player_unit.damage);
        Battle_System.enemy_hud.Set_Hp(Battle_System.enemy_unit.current_hp);
        Battle_System.dialogue.text = "The enemy took damage";

        yield return new WaitForSeconds(2f);

        if (is_dead)
        {
            Battle_System.Set_State(new Won(Battle_System));
        }
        else
        {
            Battle_System.Set_State(new Enemy_Turn(Battle_System));
        }
    }
}

