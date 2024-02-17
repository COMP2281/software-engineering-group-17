using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Battle_System : State_Machine
{

    public GameObject player_prehab;
    public GameObject enemy_prehab;

    public Transform player_battlestation;
    public Transform enemy_battlestation;

    public Combat_Unit player_unit;
    public Combat_Unit enemy_unit;

    public Text dialogue;

    public Battle_Hud player_hud;
    public Battle_Hud enemy_hud;

    // Start is called before the first frame update
    void Start()
    {
        Set_State(new Begin(this));
    }

    public void On_Attack_Button()
    {
        StartCoroutine(State.Attack());
    }
}
