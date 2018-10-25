using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abe : MonoBehaviour {

   
        
    // Use this for initialization
    void Start () {
		 
	}

    public void ButtonClicked()
    {
        
        if (WebCam.tex.isPlaying)
        {
            WebCam.tex.Stop();
            WebCam.tex = null;
            Debug.Log("Hej");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
