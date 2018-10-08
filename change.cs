using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class change : MonoBehaviour
{
    float countTime = 5; //タイマーの時間

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime; //スタートしてからの秒数を引く

        if (countTime <= 0.01)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}