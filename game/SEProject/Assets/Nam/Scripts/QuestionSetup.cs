using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class QuestionSetup : MonoBehaviour
{

    [SerializeField]
    private List<QuestionData> questions;
    private List<QuestionData> usedQuestions;
    private QuestionData currentQuestion;
    private int numberOfAnswers;

    [SerializeField]
    private TextMeshProUGUI questionText;
    [SerializeField]
    private AnswerButton[] answerButtons;

    [SerializeField]
    private int correctAnswerIndex;

    [SerializeField]
    private string world;
    private void Awake()
    {
        GetQuestionAssets();
        usedQuestions = new List<QuestionData>();
    }

    private void GetQuestionAssets()
    {
        questions = new List<QuestionData>(Resources.LoadAll<QuestionData>($"{world}"));
    }

    public void generate()
    {
        SelectNewQuestion();
        DisplayButtons();
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(answerButtons[0].gameObject);
        questionText.text = currentQuestion.question;
        SetAnswerValues();
    }

    private void SelectNewQuestion()
    {
        if (questions.Count == 0)
        {
            questions.AddRange(usedQuestions);
            usedQuestions.Clear();
        }
        int randomQuestionIndex = Random.Range(0, questions.Count);
        currentQuestion = questions[randomQuestionIndex];
        numberOfAnswers = currentQuestion.answers.Length;
        usedQuestions.Add(questions[randomQuestionIndex]);
        questions.RemoveAt(randomQuestionIndex);
    }

    private void DisplayButtons()
    {
        for (int i = 0; i < numberOfAnswers; i++)
        {
            answerButtons[i].gameObject.SetActive(true);
        }

        for (int i = numberOfAnswers; i < answerButtons.Length; i++)
        {
            answerButtons[i].gameObject.SetActive(false);
        }
    }

    public void ClearButtons()
    {
        for (int i = 0; i < answerButtons.Length; i++)
        {
            answerButtons[i].gameObject.SetActive(false);
        }
    }

    private void SetAnswerValues()
    {
        List<string> answers = RandomizeAnswers(new List<string>(currentQuestion.answers));
        for (int i = 0; i < numberOfAnswers; i++)
        {
            bool isCorrect = false;

            if (i == correctAnswerIndex)
            {
                isCorrect = true;
            }

            answerButtons[i].SetAnswer(answers[i]);
            answerButtons[i].SetIsCorrect(isCorrect);
        }
    }

    private List<string> RandomizeAnswers(List<string> originalList)
    {
        List<string> shuffledList = new List<string>();

        bool correctAnswerNotIncluded = true;

        for (int i = 0; i < numberOfAnswers; i++)
        {
            int random = Random.Range(0, originalList.Count);
            if (random == 0 && correctAnswerNotIncluded)
            {
                correctAnswerNotIncluded = false;
                correctAnswerIndex = i;
            }
            shuffledList.Add(originalList[random]);
            originalList.RemoveAt(random);
        }
        return shuffledList;
    }
}
