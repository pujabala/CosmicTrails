using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = 0.03f;
    public SpriteRenderer sr;


    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed,0f,0f);
        if (!sr.isVisible){
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D cl){
        if(cl.gameObject.tag == "Player"){
            Debug.Log("Player hit the coin via coin");
            PlayerMain.coins++; 
            Debug.Log(PlayerMain.coins);
            Destroy(gameObject);
        }
        
    }
}
