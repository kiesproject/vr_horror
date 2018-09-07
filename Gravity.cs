using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private Rigidbody Frame;
    
	// Use this for initialization
	void Start ()
    {
        Frame = this.GetComponent<Rigidbody>();
        Frame.useGravity = false;
        Physics.gravity = new Vector3(0, -30f, 0); //落下速度
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 man = GameObject.Find("Man").transform.position;
        if(man.x > -1 && man.x < 1 && man.z > -1 && man.z < 2) //物体がこの範囲を通った時重力が作動
        {
            Frame.useGravity = true;
        }
	}
}
