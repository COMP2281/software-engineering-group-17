using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class ImportQuestions
{
    private static string questionCSVPath = "/Resources/questions.csv";

    [MenuItem("Utilities/Import Questions")]
    public static void Import()
    {
        string[] allLines = File.ReadAllLines(Application.dataPath + questionCSVPath);

        // Skip first line as this is csv column name
        for (int i = 1; i < allLines.Length; i++) 
        {
            string line = allLines[i];
            Debug.Log(line);
            string[] splitData = SplitCSVLine(line);
            string[] answers = splitData[1].Split(";");
            string worldType = splitData[2];
            QuestionData questionData = ScriptableObject.CreateInstance<QuestionData>();
            questionData.question = splitData[0];
            questionData.answers = answers;
            AssetDatabase.CreateAsset(questionData, $"Assets/Resources/{worldType}/question_{i}.asset");
        }

        AssetDatabase.SaveAssets();
    }

    public static string[] SplitCSVLine(string line)
    {
        List<string> values = new List<string>();
        bool inQuotes = false;
        string currentValue = "";

        foreach (char c in line)
        {
            if (c == '"')
            {
                inQuotes = !inQuotes;
            }
            else if (c == ',' && !inQuotes)
            {
                values.Add(currentValue);
                currentValue = "";
            }
            else
            {
                currentValue += c;
            }
        }
        values.Add(currentValue);

        return values.ToArray();
    }
}
