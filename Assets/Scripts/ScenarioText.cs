using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;

public class ScenarioText : MonoBehaviour
{

    public InputField Text;
    public StreamReader sr;
    public StreamWriter sw;

    public string line;

    // Use this for initialization
    void Start()
    {
        Text = GameObject.Find("ScenarioInputField").GetComponent<InputField>();
        ReadFile();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ReadFile()
    {
        sr = new StreamReader("Assets/Resources/Scenario.txt");
        line = sr.ReadLine();
        while (line != null)
        {
            Text.text = Text.text + line + " ";
            print(line);
            line = sr.ReadLine();
        }
        sr.Close();
    }

    public void WriteFile()
    {
        sw = new StreamWriter("Assets/Resources/Scenario.txt");
        sw.Write(Text.text);
        sw.Close();
    }
}