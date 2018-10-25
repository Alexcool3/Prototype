using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneManager : MonoBehaviour {


    //bool cam = WebCam.camshouldstillbeactive;

    public void LoadScene(int index)
    {
        //WebCam.tex = null;

        if (WebCam.tex.isPlaying)
        {
            WebCam.tex.Stop();
        }

        Application.LoadLevel(index);
        if (index == 0)
        {
            //cam = false;
            //WebCam.camshouldstillbeactive = true;

        }
    }
	
	
}
