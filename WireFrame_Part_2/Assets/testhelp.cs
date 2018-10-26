using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testhelp : MonoBehaviour {
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
   
    
    public void move(int input)
    {
        Vector3 pos = target.transform.position;
        pos.x = input; //425
        target.transform.position = pos;

        Vector3 pos2 = target2.transform.position;
        pos.x = input + 170;
        pos.y = input-180;
        target2.transform.position = pos;

    }
}
