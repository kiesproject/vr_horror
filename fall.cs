using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour {
    public Transform hand;
    public Transform kakeziku;
    private Rigidbody rigid;

    // Use this for initialization
    void Start () {
        rigid = GetComponent<Rigidbody>();
        rigid.isKinematic = true;
    }

    // Update is called once per frame
    void Update() {
        if (Vector3.Distance(hand.position, kakeziku.position) >= 5)
        {
            rigid.isKinematic = false;
        }
		
	}
}
