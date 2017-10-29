using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public void showObj() {
        gameObject.GetComponent<Renderer>().enabled = true;
    }

    public void hideObj()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }
}
