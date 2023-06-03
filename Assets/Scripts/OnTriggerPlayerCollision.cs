using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerPlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag == "Asteroid"){
            Debug.Log("HIT ");
            //Destroy(gameObject);
            PlayerMain.lives-=1;
            if(PlayerMain.lives == 0){
                Destroy(gameObject);

            }

        }
        else if (collision.gameObject.tag == "Coin"){
            Debug.Log("SCORE");
            Debug.Log(PlayerMain.coins);
            
        }
    }
}
