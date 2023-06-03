using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    
    private Transform player;
    private Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
      player = GameObject.FindWithTag("Player").transform;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        temp = transform.position;
        temp.y = player.position.y;
        transform.position = temp;

    }
}
