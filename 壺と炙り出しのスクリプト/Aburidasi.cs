using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aburidasi : MonoBehaviour {
    float alfa;
    public float speed  = 0.01f;
    private float timeCount = 3;//時間の制限
    private float time;

	// Use this for initialization
	void Start () {

        alfa = 0;　　 //透明度
        time = 0;     //待機時間
        
	}

    // Update is called once per frame
    void Update() {

    }


    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.CompareTag("Effect_Eria")){ //ろうそくの火の周り(Effect_Eriaのタブを持った範囲)に当たった時

            time += 0.015f;

            if (timeCount <= time) //約三秒待ったとき
            {
                GetComponent<Renderer>().material.color = new Color(255, 0, 0, alfa);　//透明度の変化

                alfa += speed;　//透明度の変化

            }

        };

       
    }
		
	
}
