using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextlevel2 : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            Application.LoadLevel(2);

    }
}
