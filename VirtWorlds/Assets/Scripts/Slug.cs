using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slug : MonoBehaviour {

   public GameObject[] movements;
    public GameObject Player;
    int index = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, movements[index].transform.position, 0.5f);
        if (Input.GetKeyUp(KeyCode.L) && index != movements.Length)
        {
            index++;
        }
        transform.LookAt(Player.transform.position);

    }
}
