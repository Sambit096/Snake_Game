using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class Snake : MonoBehaviour {

    [Range(0f,1f)]
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
        Rotate();
	}
    private void Move()
    {
        transform.Translate(0, speed*0.1f *Time.deltaTime, 0);
    }
    private void Rotate()
    {
        transform.eulerAngles = MovementController.instance.transform.eulerAngles;
    }
   
   
        
}
