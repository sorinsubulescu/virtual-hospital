using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {


    public GameObject FPSController;
    public GameObject Screen;
    public GameObject Tablet;
    public GameObject ScenarioScreen;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
        FPSController.SetActive(true);
        Screen.SetActive(false);
        Tablet.SetActive(true);
        GameObject.Find("AnimationMaster").GetComponent<AnimationMaster>().gameStarted = true;
    }

    public void EditScenario()
    {
        Screen.SetActive(false);
        ScenarioScreen.SetActive(true);
    }

    public void MainMenu()
    {
        Screen.SetActive(true);
        ScenarioScreen.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
