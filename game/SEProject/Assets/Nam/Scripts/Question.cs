using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Question
{
    public string questionPrompt;
    public int answer;

    public Question()
    {
    }

    public void SetQuestion(string question, int correct)
    {
        questionPrompt = question;
        answer = correct;
    }
}
