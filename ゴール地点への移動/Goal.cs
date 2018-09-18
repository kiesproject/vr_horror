using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {
    public float count;
    public float alfa;
    public float alfa2;
    public float time;
    public Text text;

    // Use this for initialization
    void Start () { 
       
    }

    // Update is called once per frame
    void Update()
    {
        alfa += 0.015f;
        text.color = new Color(255, 0, 0, alfa);　//透明度の変化

        if (alfa >= 5)
        {
            
            alfa2 += 0.015f;
            text.text = "Thank you for playing"; //テキストの変更
            text.color = new Color(255, 0, 0, alfa2);//透明度の変化

            count += 0.01f;

            if (count >= 4)//約５秒
            {
                
                SceneManager.LoadScene("Horror_Poject");//スタート画面のシーンに移動

            }
        }
    }
}
