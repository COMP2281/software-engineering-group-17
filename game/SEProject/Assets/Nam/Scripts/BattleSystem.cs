using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystem : StateMachine
{

    public GameObject playerPrehab;
    public GameObject enemyPrehab;

    protected internal CombatUnit playerUnit;
    protected internal CombatUnit enemyUnit;

    protected internal Question askedQuestion;

    public TextMeshProUGUI dialogue;

    public BattleHud playerHud;
    public BattleHud enemyHud;

    void Start()
    {
        SetState(new Begin(this));
    }

    public void OnAttackButton()
    {
        StartCoroutine(State.Attack());

    }
}
