using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerButton : MonoBehaviour
{

    TimerScript timerScript;
	// Use this for initialization
	void Start ()
	{
	    timerScript = GetComponentInParent<TimerScript>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnClick()
    {
        timerScript.startTimer = true;
    }
}
