using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float time;
    TextMesh text;

    void Start()
    {
        time = 0;
        text = GetComponent<TextMesh>();
    }

    void Update()
    {
        time += Time.deltaTime;
        text.text = Mathf.Floor(time).ToString();
    }
}