using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

   public GameObject Canvas;
    public GameObject teleportSpawn;
    public GameObject plauer;
    public GameObject plauerCam;
    public GameObject cam;
    public GameObject merp;
    public GameObject myFreind;
    bool active = false;
    public GameObject finalTeleport;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       if(Input.GetKeyDown(KeyCode.O))
        {
            Canvas.SetActive(true);
            cam.SetActive(true);
            plauerCam.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            merp.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            toHell();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            active = true;

        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            plauer.transform.position = finalTeleport.transform.position;

        }
        if (active)
            myFreind.transform.position = Vector3.MoveTowards(myFreind.transform.position, plauer.transform.position, 0.03f);

        myFreind.transform.LookAt(plauer.transform.position);

    }

    public void toHell()
    {
        Canvas.SetActive(false);
        plauerCam.SetActive(true);
       cam.SetActive(false);
        plauer.transform.position = teleportSpawn.transform.position;
    }
}
