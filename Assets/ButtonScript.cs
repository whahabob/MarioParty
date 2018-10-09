using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

    // Use this for initialization
    public GameObject name1, name2, name3, name4;
	void Start () {
        this.gameObject.GetComponent<Button>().enabled = false;
        this.gameObject.GetComponent<Image>().enabled = false;

        this.gameObject.GetComponentInChildren<Text>().text = "";
    }
	
	// Update is called once per frame
	void Update () {
        
        
        if(name1.GetComponentInChildren<Text>().text != "" && 
            name2.GetComponentInChildren<Text>().text != "" && 
            name3.GetComponentInChildren<Text>().text != "" && 
            name4.GetComponentInChildren<Text>().text != "")
        {
            this.gameObject.GetComponent<Button>().enabled = true;
            this.gameObject.GetComponent<Image>().enabled = true;
            this.gameObject.GetComponentInChildren<Text>().text = "Start";
        }
        else
        {
            this.gameObject.GetComponent<Button>().enabled = false;
            this.gameObject.GetComponent<Image>().enabled = false;

            this.gameObject.GetComponentInChildren<Text>().text = "";
        }
		
	}
    public void OnClick()
    {
        SceneManager.LoadScene("PlayScreen");
    }
}
