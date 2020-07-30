using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float maxSpeed = 4f;
    public float speed = 2f;
    public bool ground;
    public float jumpPower = 9.5f;

    private Rigidbody2D rb2d;
    private Animator anim;
    private bool jump;
    
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   

        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Ground", ground);

        if (Input.GetKeyDown(KeyCode.UpArrow) && ground)
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        //Vector3 fixedVelocity = rb2d.velocity;
        //fixedVelocity.x *= 0.85f;
        
        //if(ground)
        //{
            //rb2d.velocity = fixedVelocity;
        //}
        

        float h = Input.GetAxis("Horizontal");
        rb2d.AddForce(Vector2.right * speed * h);

        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);
        if(h > 0.1f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);

        }
        if(h < -0.1f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        if (jump)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0);
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
            jump = false;
        }
        Debug.Log(rb2d.velocity.x);
    }
    
    void OnBecameInvisible()
    {
        transform.position = new Vector3(-8, 9, 0);
    }
}
