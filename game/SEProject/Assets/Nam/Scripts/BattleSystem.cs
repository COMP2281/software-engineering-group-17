using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BattleSystem : StateMachine
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    protected internal CombatUnit playerUnit;
    protected internal CombatUnit enemyUnit;

    protected internal QuestionSetup askedQuestion;

    public TextMeshProUGUI dialogue;

    public BattleHud playerHud;
    public BattleHud enemyHud;

    void Start()
    {
        SetState(new Begin(this));
    }

    public void OnAnswer(bool option)
    {
        StartCoroutine(State.Answer(option));
    }
}
