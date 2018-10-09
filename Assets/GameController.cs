using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    // Use this for initialization
    public GameObject name, scoreAdd, score;
    private GameObject[] playersList, scoreAddList, scoreList;
	void Start () {

     
    }
	
	// Update is called once per frame
	void Update () {
        //name1.GetComponentInChildren<Text>().text


    }
    public void addScore()
    {
        int tempScoreAdd, tempScore, newScore;
        int.TryParse(scoreAdd.GetComponentInChildren<Text>().text, out tempScoreAdd);
        int.TryParse(score.GetComponentInChildren<Text>().text, out tempScore);
        newScore = tempScore + tempScoreAdd;
        score.GetComponent<Text>().text = newScore.ToString();

        InputField inputField = GetComponentInParent<InputField>();
        inputField.text = "";
        scoreAdd.GetComponentInChildren<Text>().text = "";
    }
}
