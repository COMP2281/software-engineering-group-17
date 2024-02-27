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
        string[] allLLines = File.ReadAllLines(Application.dataPath + questionCSVPath);

        foreach (string line in allLLines)
        {
            string[] splitData = SplitCSVLine(line);
            Debug.Log(string.Join("\n", splitData));
        }
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
