using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    int scorecoins;


    void Start()
    {
        scorecoins = PlayerMain.coins ;
        score.text = "SCORE: 0";
    }

    // Update is called once per frame
    void Update()
    {
        scorecoins = PlayerMain.coins ;
        score.text = "SCORE: " + scorecoins.ToString();
    }
}
