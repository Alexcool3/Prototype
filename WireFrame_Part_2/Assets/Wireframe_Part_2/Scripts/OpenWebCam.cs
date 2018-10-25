using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWebCam : MonoBehaviour {

	// Use this for initialization
	void Start () {
        WebCamTexture webcamTexture = new WebCamTexture();
        WebCamDevice[] devices = WebCamTexture.devices;
        webcamTexture.deviceName = devices[0].name;
        this.GetComponent<MeshRenderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play(); 


    }

    // Update is called once per frame
    void Update () {
		
	}
}
