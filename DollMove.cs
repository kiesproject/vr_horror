using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollMove : MonoBehaviour {
    public Transform player;
    public GameObject DollTurn;
    public GameObject Butsudan;
    public GameObject hand;
    bool A = false;

	// Use this for initialization
	void Start () {
        Butsudan = GameObject.Find("Butsudan");
        hand = GameObject.Find("Hand");
        DollTurn = GameObject.Find("DollTurn");
	}
	
	// Update is called once per frame
	void Update () {
        //var trackedObject = GetComponent<SteamVR_TrackedObject>();
        //var device = SteamVR_Controller.Input((int)trackedObject.index);
        //if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        if (Input.GetKeyDown(KeyCode.X))
        {
            if ((Vector3.Distance(this.gameObject.transform.position, hand.gameObject.transform.position) <= 5.0f)) {
                if (A == false) {
                    this.gameObject.transform.LookAt(player);
                    Butsudan.gameObject.transform.Translate(0, 5, 0);
                    A = true;
                    DollLook.Turn = true;
                } }
        }

    }
}
