using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour {

    public static int score = 100;

    public Text textObj;


	// Use this for initialization
	void Start () {
        int oldscore = PlayerPrefs.GetInt("score", 0);
        score = oldscore;
        



    }
	
	// Update is called once per frame
	void Update () {
        score = PlayerController.gold;
        var textComp = textObj.GetComponent<Text>();
        textComp.text = score.ToString();


    }

    public void StoreHighscore(int newHighscore)
    {
        int oldHighscore = PlayerPrefs.GetInt("highscore", 0);
        if (newHighscore > oldHighscore)
            PlayerPrefs.SetInt("highscore", newHighscore);
    }

    public void StoreScore(int newscore)
    {
         PlayerPrefs.SetInt("score", newscore);
    }

}
