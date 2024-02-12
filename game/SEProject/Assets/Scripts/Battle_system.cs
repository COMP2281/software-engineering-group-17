using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Battle_State { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class Battle_system : MonoBehaviour
{

    public GameObject player_prehab;
    public GameObject enemy_prehab;

    public Transform player_battlestation;
    public Transform enemy_battlestation;

    Combat_Unit player_unit;
    Combat_Unit enemy_unit;

    public Text dialogue;

    public Battle_Hud player_hud;
    public Battle_Hud enemy_hud;

    public Battle_State state;

    // Start is called before the first frame update
    void Start()
    {
        state = Battle_State.START;
        StartCoroutine(Setup_Battle());
    }

    IEnumerator Setup_Battle()
    {
        GameObject player_go = Instantiate(player_prehab, player_battlestation);
        player_unit = player_go.GetComponent<Combat_unit>();

        GameObject enemy_go = Instantiate(enemy_prehab, enemy_battlestation);
        enemy_unit = enemy_go.GetComponent<Combat_unit>();

        dialogue.text = "Question Question Question Question";

        player_hud.Set_hud(player_unit);
        enemy_hud.Set_hud(enemy_unit);

        yield return new WaitForSeconds(2f);

        state = Battle_State.PLAYERTURN;
        Player_Turn();
    }

    void Player_Turn()
    {
        dialogue.text = "User action User action User action User action";
    }

    IEnumerator Player_Attack()
    {
        bool is_dead = enemy_unit.Take_damage(player_unit.damage);
        enemy_hud.Set_hp(enemy_unit.current_hp);
        dialogue.text = "The enemy took damage";

        yield return new WaitForSeconds(2f);

        if (is_dead)
        {
            state = Battle_State.WON;
            End_Battle();
        } else
        {
            state = Battle_State.ENEMYTURN;
            StartCoroutine(Enemy_Turn());
        }
    }

    void End_Battle()
    {
        if (state == Battle_State.WON)
        {
            dialogue.text = "You won!";
        } else if (state == Battle_State.LOST)
        {
            dialogue.text = "You lost!";
        }
    }

    IEnumerator Enemy_Turn()
    {
        dialogue.text = "Question";

        yield return new WaitForSeconds(1f);

    }
}
