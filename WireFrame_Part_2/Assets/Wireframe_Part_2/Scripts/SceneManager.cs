using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {

    //bool cam = WebCam.camshouldstillbeactive;

    public void LoadScene(int index)
    {
        //WebCam.tex = null;
        Application.LoadLevel(index);
      
        if (WebCam.tex.isPlaying)
        {
            WebCam.tex.Stop();
        }
    }
		
}
