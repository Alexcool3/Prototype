using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputText : MonoBehaviour {

    public Text text;
    public string inputText;
    public static string[] validSearch = {"1"};

	// Use this for initialization
	void Start () {
        text.text = inputText;
        
	}
	
    void EnterText()
    {

    }
	
}
