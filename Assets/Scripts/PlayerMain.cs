using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    private Vector2 Screensize;

    [SerializeField]
    public static float health = 20f;

    public static int coins = 0;
    public static int stars = 0;
    public static int lives = 5;

    public static bool isOnScreen = true;
    [SerializeField]
    private float MoveForce = 10f;

    

    private float movy;

    [SerializeField]
    private Rigidbody2D mybody;

    [SerializeField]
    private Animator anim;
    
    [SerializeField]
    private SpriteRenderer sr;

    private Camera cam;
 
    // Start is called before the first frame update
    void Start()
    {
        Screensize = new Vector2(Screen.width, Screen.height);
        mybody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        cam = Camera.main;
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
        if (isOnScreen){
                transform.position += new Vector3(0f,movy,0f) *Time.deltaTime *MoveForce;
        }
        
        if (transform.position.y >9){
            transform.position = new Vector3(transform.position.x,9,transform.position.z);
        }
        else if (transform.position.y <1){
            transform.position = new Vector3(transform.position.x,1,transform.position.z);
        }
    }

    



    
}


