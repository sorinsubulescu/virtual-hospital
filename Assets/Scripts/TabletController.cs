using UnityEngine;
using System.Collections;

public class TabletController : MonoBehaviour {

    public GameObject MainMenu;
    public GameObject QuestionsMenu;
    public GameObject AnalysisMenu;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenQuestionsMenu()
    {
        MainMenu.SetActive(false);
        QuestionsMenu.SetActive(true);
    }

    public void OpenMainMenu()
    {
        MainMenu.SetActive(true);
        QuestionsMenu.SetActive(false);
        AnalysisMenu.SetActive(false);
    }

    public void OpenAnalysisMenu()
    {
        MainMenu.SetActive(false);
        AnalysisMenu.SetActive(true);
    }

}
