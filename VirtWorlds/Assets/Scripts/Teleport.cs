using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

   public GameObject Canvas;
    public GameObject teleportSpawn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       if(Input.GetKeyDown(KeyCode.O))
        {
            Canvas.SetActive(true);
        }
		
	}

    public void toHell()
    {
        Canvas.SetActive(false);
        gameObject.transform.position = teleportSpawn.transform.position;
    }
}
