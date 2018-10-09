using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [SerializeField]
    Text timer;


    public bool startTimer;

    UIController uiController;
    public float durationTime = 20;
	// Use this for initialization
	void Start ()
	{
	    uiController = GetComponentInParent<UIController>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	    durationTime = Mathf.Clamp(durationTime, 0, Mathf.Infinity);
        if (startTimer)
	    {
	        StartTimer();
	    }
	}

    void StartTimer()
    {
        if (durationTime <= 0)
        {
            startTimer = false;
            uiController.MinigameRandomizer();
            return;
        }
        durationTime -= Time.fixedDeltaTime;
        timer.text = Mathf.FloorToInt(durationTime).ToString();
    }
}
