using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour

{
    private playercontroller c18;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        c18 = GetComponentInParent<playercontroller>();
        rb2d = GetComponentInParent<Rigidbody2D>();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
        {
            rb2d.velocity = new Vector3(0f, 0f, 0f);
            c18.transform.parent = col.transform;
            c18.ground = true;
        }

    }
    // Update is called once per frame
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            c18.ground = true;
        }
        if (col.gameObject.tag == "Platform")
        {
            c18.transform.parent = col.transform;
            c18.ground = true;
        }


    }
    void OnCollisionExit2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            c18.ground = false;
        }
        if (col.gameObject.tag == "Platform")
        {
            c18.transform.parent = null;
            c18.ground = false;
        }

    }
}