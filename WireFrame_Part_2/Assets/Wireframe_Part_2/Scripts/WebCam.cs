using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour {

	int currentIndex = 0;
    public static WebCamTexture tex;
    public RawImage display;
    public GameObject button;
    //public static bool camshouldstillbeactive = false;
    private void Start()
    {
        button = GameObject.Find("Start");
        
    }
    

    void ButtonClicked()
    {
        button.SetActive(false);
        //camshouldstillbeactive = true;
    }
	
    public void startStop()
    {
        //tex = new WebCamTexture();
        /*
        tex.Play();
        if (tex.isPlaying)
        {
            display.texture = tex;
            WebCamDevice device = WebCamTexture.devices[currentIndex];
            tex = new WebCamTexture(device.name);
            display = GetComponent<RawImage>();
            
        }
        */
        ButtonClicked();
                       
        if (tex != null)
        {
           
            display.texture = null;
            tex.Stop();
            tex = null;
        }
        else //if(camshouldstillbeactive==true)
        {
            WebCamDevice device = WebCamTexture.devices[currentIndex];
            tex = new WebCamTexture(device.name);
            display.texture = tex;
            tex.Play();
        }
        

    }
      	
}
