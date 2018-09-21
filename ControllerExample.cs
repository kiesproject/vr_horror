using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerExample : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		var device = SteamVR_Controller.Input((int)trackedObject.index);

		if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			SceneManager.LoadScene ("main");
		}

	}
}
