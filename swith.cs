using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swith : MonoBehaviour
{
    public GameObject KLight; //オブジェクト名
    Light light;
    public bool LightState = false; //ライトの初期設定

    // Use this for initialization
    void Start()
    {
        light = KLight.GetComponent<Light>();
        light.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //マウス左クリック時反転
        {
            if(LightState == false)
            {
                LightState = true;
            }
            else
            {
                LightState = false;
            }
            OnOff();
        }
    }

    void OnOff()
    {
        if (LightState == false)
        {
            light.intensity = 1;
        }
        else
        {
            light.intensity = 0;
        }
    }
}
