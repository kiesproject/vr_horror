using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controler : MonoBehaviour {
    public Rigidbody Player;
    public Transform main_camera;
    public GameObject LC; //VRのコントローラー

	// Use this for initialization
	void Start () {

        Player = GetComponent<Rigidbody>();

	}

    // Update is called once per frame
    void Update() {
        var trackedObject = LC.GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);

        Vector3 z = main_camera.transform.forward;//カメラの青軸を取得
        
        if(device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Player.velocity = z;//プレイヤーがカメラの向いた方向に移動
        }
		
	}

}
