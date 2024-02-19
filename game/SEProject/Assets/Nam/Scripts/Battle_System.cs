using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Battle_System : State_Machine
{

    public GameObject player_prehab;
    public GameObject enemy_prehab;

    protected internal Combat_Unit player_unit;
    protected internal Combat_Unit enemy_unit;

    protected internal Question asked_question;

    public TextMeshProUGUI dialogue;

    public Battle_Hud player_hud;
    public Battle_Hud enemy_hud;

    void Start()
    {
        Set_State(new Begin(this));
    }

    public void On_Attack_Button()
    {
        StartCoroutine(State.Attack());

    }
}
