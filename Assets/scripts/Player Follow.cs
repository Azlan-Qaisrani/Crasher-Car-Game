using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class PlayerFollow : MonoBehaviour

{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -11);
   
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void LateUpdate()

    {
        
               

      transform.position = player.transform.position + offset;
             
     
       
       
    }
}