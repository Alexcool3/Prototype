using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Search : MonoBehaviour {

    SceneManager sceneManager = new SceneManager();
    public InputField input;
    public Text text;
    private bool valid;
    private string[] validSearch = { "1" };
	
    public void ButtonClicked()
    {

        for (int i = 0; i < validSearch.Length; i++)
        {
            if (input.text == validSearch[i])
            {
                valid = true;
            }
            else
            {
                input.text = "Ingen resultater";
            }
        }

        if (valid == true)
        {
            sceneManager.LoadScene(0);
        }

    }

}
