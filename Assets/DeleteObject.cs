using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteObject : MonoBehaviour
{


    private GameObject unitychan;


    // Use this for initialization
    void Start()
    {
        this.unitychan = GameObject.Find("unitychan");
               
       // var anotherTransform1 = GameObject.Find("unitychan").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(this.unitychan.transform.position.z -10 > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
        //this.unitychan.transform.position.z

        //this.transform.position.z
    }
    
}