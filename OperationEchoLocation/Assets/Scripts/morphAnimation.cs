using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morphAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("LeftJoyY") < 0)
        {
            GetComponent<Animation>().Blend("run");
        }
        else { //GetComponent<Animation>().Stop("run");
            GetComponent<Animation>().CrossFade("stop");
        }
       // if (Input.GetKey(("down")))
      //  {
            
       //     GetComponent<Animation>().Blend("stop");
       // }


    }
}
