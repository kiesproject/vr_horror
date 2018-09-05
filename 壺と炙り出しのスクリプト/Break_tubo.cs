using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Break_tubo : MonoBehaviour {
    public GameObject obj;　


	// Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.CompareTag("ground")){　//「グラウンド」タグを取得したとき

            Destroy(gameObject); //壺を破壊

            GameObject instance = (GameObject)Instantiate(obj);　//プレハブから出現させる

            instance.transform.position = gameObject.transform.position;　//衝突した座標を取得してプレハブを設置

        };


    }

}
