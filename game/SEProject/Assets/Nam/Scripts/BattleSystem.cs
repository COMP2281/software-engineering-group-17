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

    protected internal Question askedQuestion;

    public TextMeshProUGUI dialogue;

    public BattleHud playerHud;
    public BattleHud enemyHud;

    void Start()
    {
        SetState(new Begin(this));
    }

    public void OnAnswer1Button()
    {
        StartCoroutine(State.Answer(1));
    }

    public void OnAnswer2Button()
    {
        StartCoroutine(State.Answer(2));
    }

    public void OnAnswer3Button()
    {
        StartCoroutine(State.Answer(3));
    }

    public void OnAnswer4Button()
    {
        StartCoroutine(State.Answer(4));
    }

    public void OnAnswer5Button()
    {
        StartCoroutine(State.Answer(5));
    }
}
