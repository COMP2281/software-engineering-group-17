using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AnswerButton : MonoBehaviour
{
    public BattleSystem battleSystem;
    private bool isCorrect;
    [SerializeField]
    private TextMesh option;

    public void SetAnswer(string newOption)
    {
        option.text = newOption;
    }

    public void SetIsCorrect(bool newBool)
    {
        isCorrect = newBool;
    }

    public void OnClick()
    {
        if (isCorrect)
        {
            Debug.Log("correct");
        }
        else
        {
            Debug.Log("incorrect");
        }
    }
}
