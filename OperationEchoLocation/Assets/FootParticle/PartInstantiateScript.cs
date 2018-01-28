using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartInstantiateScript : MonoBehaviour {

    public Transform particlePrefab;
    public GameObject footLocation;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Emit")) {

            Transform part = Instantiate(particlePrefab, footLocation.transform.position, transform.rotation) as Transform;

        }

	}
}
