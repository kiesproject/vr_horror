using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollLook : MonoBehaviour {
    public Transform player;
    public static bool Turn;
    bool T = false;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Turn == true)
        {
            if (T == false) {
                this.gameObject.transform.LookAt(player);
                T = true;
            } }
		
	}
}
