using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelenMove : MonoBehaviour
{
    public float maxSpeed;
    Rigidbody2D rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        //Move By Key Control
        //float h = Input.GetAxisRaw("Horizontal");
        
        //rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        //if (rigid.velocity.x > maxSpeed) //Right max Speed
        //    rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        //else if (rigid.velocity.x < maxSpeed*(-1)) //Left max Speed
        //    rigid.velocity = new Vector2(maxSpeed*(-1), rigid.velocity.y);
    }
}
