using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{	
	// Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
            Application.LoadLevel(0);
    }
}
