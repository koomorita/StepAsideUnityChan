using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour {

        
    // Use this for initialization
    void Start () {
    
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnBecameInvisible()
    {
        //画面外の障害物を消去する。
        GameObject.Destroy(this.gameObject);

    }
}
