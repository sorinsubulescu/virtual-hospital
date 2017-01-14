using UnityEngine;
using System.Collections;

public class AnimationMaster : MonoBehaviour {

    public bool gameStarted = false;
    public bool doorOpen;
    public bool reachesBed = false;
    public bool hasTablet = false;
    private Animator patientAnim;
    private Animator patientParentAnim;
    private Animator tabletAnim;
    private Animator doorAnim;

	// Use this for initialization
	void Start () {
        patientAnim = GameObject.Find("Bob").GetComponent<Animator>();
        tabletAnim = GameObject.Find("Tablet").GetComponent<Animator>();
        doorAnim = GameObject.Find("DoorPivotPoint").GetComponent<Animator>();
	}

    // Update is called once per frame
    void Update()
    {
        doorAnim.SetBool("gameStarted", gameStarted);

        doorOpen = doorIsOpen();
        patientAnim.SetBool("doorOpen", doorOpen);
        patientAnim.SetBool("reachesBed", reachesBed);

        if (gameStarted)
        {
            callForTablet();
            tabletAnim.SetBool("hasTablet", hasTablet);
        }
    }

    bool doorIsOpen()
    {
        if (GameObject.Find("DoorPivotPoint").GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("doorStayOpen"))
        {
            return true;
        }
        else
            return false;
    }

    void callForTablet()
    {
        if (Input.GetKeyDown("f"))
        {
            hasTablet = !hasTablet;
        }
    }

}

