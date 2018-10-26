using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiitScript : MonoBehaviour {

    private void Update()
    {
        
        //QuitGame();
    }
    public void ButtonClicked()
    {
        
        QuitGame();
    }
    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }
}
