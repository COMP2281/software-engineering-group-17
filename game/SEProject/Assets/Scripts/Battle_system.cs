using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum Battle_state { START, PLAYERTURN, ENEMYTURN, WON, LOST }

public class Battle_system : MonoBehaviour
{

    public GameObject player_prehab;
    public GameObject enemy_prehab;

    public Transform player_battlestation;
    public Transform enemy_battlestation;

    Combat_unit player_unit;
    Combat_unit enemy_unit;

    public Text dialogue;

    public Battle_hud player_hud;
    public Battle_hud enemy_hud;

    public Battle_state state;

    // Start is called before the first frame update
    void Start()
    {
        state = Battle_state.START;
        StartCoroutine(SetupBattle());
    }

    IEnumerator SetupBattle()
    {
        GameObject player_go = Instantiate(player_prehab, player_battlestation);
        player_unit = player_go.GetComponent<Combat_unit>();

        GameObject enemy_go = Instantiate(enemy_prehab, enemy_battlestation);
        enemy_unit = enemy_go.GetComponent<Combat_unit>();

        dialogue.text = "Question Question Question Question";

        player_hud.Set_hud(player_unit);
        enemy_hud.Set_hud(enemy_unit);

        yield return new WaitForSeconds(2f);

        state = Battle_state.PLAYERTURN;
        Player_turn();
    }

    void Player_turn()
    {
        dialogue.text = "User action User action User action User action";
    }
}
