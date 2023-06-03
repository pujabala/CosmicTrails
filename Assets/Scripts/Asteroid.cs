using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Asteroid : MonoBehaviour
{
    //[SerializedField]
    public float speed = 0.03f;
    
    private int randomIndex;
    private Vector2 Screensize;

    //[SerializedField]
    public float MoveForce = 10f;

    public SpriteRenderer sr;

    private Rigidbody2D body;
    // Start is called before the first frame update
    void Awake()
    {
        Screensize = new Vector2(Screen.width, Screen.height);
        body = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(speed,0f,0f);
        //gameObject.SetActive(false);
        if (!sr.isVisible){
            Destroy(gameObject);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        Destroy(gameObject);
        //hello
    }


}
