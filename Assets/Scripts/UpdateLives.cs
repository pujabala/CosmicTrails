using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateLives : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ll;
    int livesLeft;


    void Start()
    {
        ll.text = "LIVES: 5";
    }

    // Update is called once per frame
    void Update()
    {
        livesLeft = PlayerMain.lives ;
        ll.text = "LIVES: " + livesLeft.ToString();
    }
}