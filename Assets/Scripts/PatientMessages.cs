using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PatientMessages : MonoBehaviour {

    private Text message;
    public Transform player;
    public PlayerBehaviour behaviour;

	// Use this for initialization
	void Start () {
        message = GameObject.Find("PatientMessage").GetComponent<Text>();
        behaviour = GameObject.Find("ScoringSystem").GetComponent<PlayerBehaviour>();
	}
	
	// Update is called once per frame
	void Update () {
        //Rotation of the text to follow the player
        transform.rotation = player.rotation;
	}

    public void Answer1()
    {
        message.text = "Answer 1";
        behaviour.actions.Add("QUESTION1");

    }

    public void Answer2()
    {
        message.text = "Answer 2";
        behaviour.actions.Add("QUESTION2");
    }

    public void Answer3()
    {
        message.text = "Answer 3";
        behaviour.actions.Add("QUESTION3");
    }

    public void Analysis1()
    {
        message.text = "Ok, I will go to Analysis1";
        behaviour.actions.Add("ANALYSIS1");
    }

    public void Analysis2()
    {
        message.text = "Ok, I will go to Analysis2";
        behaviour.actions.Add("ANALYSIS2");
    }

    public void Analysis3()
    {
        message.text = "Ok, I will go to Analysis3";
        behaviour.actions.Add("ANALYSIS3");
    }


}
