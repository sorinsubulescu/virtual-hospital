using UnityEngine;
using System.Collections;

public class IdleTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if(GameObject.FindGameObjectWithTag("Patient"))
        {
            GameObject.Find("AnimationMaster").GetComponent<AnimationMaster>().reachesBed = true;
        }
    }

   /* void OnTriggerExit(Collider col)
    {
        if (GameObject.FindGameObjectWithTag("Patient"))
        {
            GameObject.Find("AnimationMaster").GetComponent<AnimationMaster>().reachesBed = false;
        }
    }
    */
}
