using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public minigame currentMinigame;

    [SerializeField]
    Object[] miniGamesObject;

    [SerializeField]
    Text minigameName,minigameDescription, minigameTime;

    [SerializeField]
    List<minigame> minigameDoneList = new List<minigame>();
	// Use this for initialization
	void Start () {
        miniGamesObject = Resources.LoadAll("Minigames");
    }
	
	// Update is called once per frame
	void Update () {
        UpdateMinigameText();

        if (Input.GetKeyDown(KeyCode.Home))
        {
            MinigameRandomizer();
        }
    }

    void UpdateMinigameText()
    {
        minigameName.text = currentMinigame.name;
        minigameDescription.text = currentMinigame.description;
        minigameTime.text = "Time: " + currentMinigame.time.ToString();
    }

    void MinigameRandomizer()
    {
        int randomNumber;

        while (true)
        {
            randomNumber = Random.Range(0, miniGamesObject.Length-1);
            bool minigameDone = false;
            foreach (minigame m in minigameDoneList)
            {
                if (m == (minigame)miniGamesObject[randomNumber])
                {
                    Debug.Log("zelfde");
                    minigameDone = true;
                }
            }
            if(!minigameDone)
            {
                Debug.Log("voegtoe");
                currentMinigame = (minigame)miniGamesObject[randomNumber];
                minigameDoneList.Add(currentMinigame);
                break;
            }

            if (minigameDoneList.Count-1 == miniGamesObject.Length)
            {
                Debug.Log("count: " + minigameDoneList.Count + "lenght: " + miniGamesObject.Length);
                break;
            }
        }
    }
}
