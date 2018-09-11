using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorR : MonoBehaviour {
	private Animator anim;

	// Use this for initialization
	void Start()
	{
		anim = transform.parent.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
	}

	void OnTriggerEnter(Collider col)
	{
		int count = GameObject.FindGameObjectsWithTag ("Item").Length;
		if (col.gameObject.tag == "Player" & count == 0) {
			anim.SetTrigger ("Open");
		}
	}


}