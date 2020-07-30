using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class cambioescena : MonoBehaviour
{
  

    void OnTriggerEnter2d(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("nivel1.0", LoadSceneMode.Single);
        }
    }
}

