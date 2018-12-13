using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creb : MonoBehaviour {

    public GameObject[] movements;
    public GameObject Player;
    public GameObject[] crebz;
    public int index = 0;
    // Use this for initialization
    void Start () {
        crebz = GameObject.FindGameObjectsWithTag("MyWeiner");
	}
	
	// Update is called once per frame
	void Update () {
		foreach(GameObject crb in crebz)
        {
            crb.transform.LookAt(Player.transform.position);
        }
      transform.LookAt(Player.transform.position);
        transform.position = Vector3.MoveTowards(transform.position, movements[index].transform.position, 0.8f);

        if (Input.GetKeyUp(KeyCode.K) && index != movements.Length)
        {
            index++;
        }
    }
}
