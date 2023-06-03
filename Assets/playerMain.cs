using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMain : MonoBehaviour
{
    //[SerializedField]
    public int lives = 5;

   // [SerializedField]
    public float health = 20f;

    //[SerializedField]
    public float MoveForce = 10f;

    //[SerializedField]
    public float Velocity = 10f;

    private float movy;

    //[SerializedField]
    public Rigidbody2D mybody;

    //[SerializedField]
    public Animator anim;
    
    //[SerializedField]
    public SpriteRenderer sr;
 
    // Start is called before the first frame update
    void Start()
    {
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        mybody.gravityScale = 0;
        //anim.SetBool(ROCKET_ANIMATION,true);
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerKeyboardMovement();
        
    }

    void PlayerKeyboardMovement(){
        movy = Input.GetAxis("Vertical");

        transform.position += new Vector3(0f,movy,0f) *Time.deltaTime *MoveForce;
    }

    



    
}

