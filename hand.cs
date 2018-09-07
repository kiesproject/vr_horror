using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class hand : MonoBehaviour {
    
    bool onKey = false;
    bool onGet = false;
    GameObject tmp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        try{
            var trackedObject = GetComponent<SteamVR_TrackedObject>();
            var device = SteamVR_Controller.Input((int)trackedObject.index);

            if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
            {
                Debug.Log("トリガーを深く引いた");
                onKey = true;
            }
            if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
            {
                Debug.Log("トリガーを離した");
                onKey = false;
            }
        }
        catch
        {
            
        }


        if (Input.GetKeyDown(KeyCode.X))
        {
            onKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            onKey = false;
        }

        Debug.Log(onKey);

	}

    void OnTriggerStay(Collider c)
    {
        string layerName = LayerMask.LayerToName(c.gameObject.layer);
        if (layerName == "possible")
        {
            if (onGet == false)//今手に何か持っているか？
            {
                if (onKey == true)//キー入力があるかどうか
                {

                    //掴む
                    Rigidbody rig = c.gameObject.GetComponent<Rigidbody>();
                    rig.useGravity = false;
                    onGet = true;
                    tmp = c.gameObject;
                    c.gameObject.transform.parent = this.gameObject.transform;
                }
            }
            else
            {
                if (onKey == false)//キー入力があるかどうか
                {

                    //掴む
                    Rigidbody rig = c.gameObject.GetComponent<Rigidbody>();
                    Scene works = SceneManager.GetSceneByName("Stage");
                    rig.useGravity = true;
                    onGet = false;

                    tmp.gameObject.transform.parent = null;
                    
                }
            }

        }
    }

}
