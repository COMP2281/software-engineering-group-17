using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    public AnswerButton[] answerButtons;

    public void DisplayButtons(int numberOfAnswers)
    {
        for (int i = 0; i < numberOfAnswers; i++)
        {
            answerButtons[i].gameObject.SetActive(true);
        }

        for (int i = numberOfAnswers; i < answerButtons.Length; i++)
        {
            answerButtons[i].gameObject.SetActive(false);
        }

        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(answerButtons[0].gameObject);
    }

    public void ClearButtons()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].gameObject.SetActive(false);
        }
    }
}
