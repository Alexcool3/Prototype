using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour {

    GameObject exampleDialog;

    private void Start()
    {
        //exampleDialog = GameObject.Find("ExampleDialog");
    }

    public void ButtonClicked()
    {
        exampleDialog.SetActive(false);
    }
	
}
