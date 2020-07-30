using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CkeckIn : MonoBehaviour

{
    private playercontroller c18;
    // Start is called before the first frame update
    void Start()
    {
        c18 = GetComponentInParent<playercontroller>();
    }

    // Update is called once per frame
    void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            c18.ground = true;
        }
        if(col.gameObject.tag == "Platform")
        {
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
            c18.ground = false;
        }

    }
}