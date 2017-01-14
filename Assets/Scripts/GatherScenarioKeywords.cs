using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public class GatherScenarioKeywords : MonoBehaviour {

    //  public string scenario;
    public List<string> scenario;
    private string line;
    public StreamReader sr;
    public List<string> keywords;
    public List<string> scenarioKeywords;

    // Use this for initialization
    void Start () {
        ReadFile();
        ReadKeywords();
        FindKeywordsInScenario();
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void ReadFile()
    {
        scenario.Clear();
        sr = new StreamReader("Assets/Resources/Scenario.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            int j = 0;
            int i;
            int count = 0;
            for (i = 0; i < line.Length; i++, count++)
            {

                if (line[i] == ' ' || i==line.Length - 1)
                {
                    scenario.Add(line.Substring(j, count));
                    j = i + 1;
                    count = -1;
                }
            }
            print(line);
            line = sr.ReadLine();
        }
        sr.Close();
    }

    public void ReadKeywords()
    {
        sr = new StreamReader("Assets/Resources/Keywords.txt");
        line = sr.ReadLine();
        while(line != null)
        {
            keywords.Add(line);
            line = sr.ReadLine();
        }
        sr.Close();
    }

    public void FindKeywordsInScenario()
    {
        scenarioKeywords.Clear();
        int i, j;
        for (i = 0; i < scenario.Count; i++)
        {
            for (j = 0; j < keywords.Count; j++)
            {
                if (string.Compare(scenario[i], keywords[j], true) == 0)
                    scenarioKeywords.Add(scenario[i]);
            }
        }
    }

}
