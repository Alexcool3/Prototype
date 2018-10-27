using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class searchpopup : MonoBehaviour {
    GameObject go;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(target.transform.position.x);
    }
    public Transform target;
    public Transform target2;
    public Transform target3;
    public Transform target4;

    public void move(int input)
    {
        Vector3 pos = target.transform.position;
        pos.x = input+300; //425
        target.transform.position = pos;

        Vector3 pos3 = target3.transform.position;
        pos.x = input + 210; //425
        target3.transform.position = pos;

        Vector3 pos2 = target2.transform.position;
        pos.x = input + 448;
        target2.transform.position = pos;

        Vector3 pos4 = target4.transform.position;
        pos.x = input + 620; //425
        pos.y = input + 60;
        target4.transform.position = pos;


    }
}
