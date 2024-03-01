using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BattleSystem : StateMachine
{

    public GameObject playerPrefab;
    public GameObject enemyPrefab;

    protected internal CombatUnit playerUnit;
    protected internal CombatUnit enemyUnit;

    public QuestionSetup questionManager;
    public ButtonManager buttonManager;

    public TextMeshProUGUI dialogue;

    public BattleHud playerHud;
    public BattleHud enemyHud;

    public string nextScene;
    public string previousScene;

    void Start()
    {
        SetState(new Begin(this));
    }

    public void OnAnswer(bool option)
    {
        buttonManager.ClearButtons();
        StartCoroutine(State.Answer(option));
    }
}
