using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tereport : MonoBehaviour {
    public GameObject pla;　//プレイヤー

	// Use this for initialization
	void Start () {

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Sciene2");//ゴール地点のシーンに移動

        }
    }
}
