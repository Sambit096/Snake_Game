using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour {

    private Camera myCam;
    private Vector3 screenPos;
    private float angleOffset;
    public static MovementController instance;
    bool allowMovement=true;
	// Use this for initialization
	void Start () {
        if(instance==null)
        {
            instance = this;
        }
        else
        {
            Debug.Log("Destroying Object");
            Destroy(this.gameObject);
        }
        myCam = Camera.main;
    }
	
	// Update is called once per frame
	void Update () {
        RotateWheel();
	}

    public void RotateWheel()
    {
        if(allowMovement)
        {
            if (Input.GetMouseButtonDown(0))
            {
                screenPos = myCam.WorldToScreenPoint(transform.position);
                Vector3 v3 = Input.mousePosition - screenPos;
                angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(v3.y, v3.x)) * Mathf.Rad2Deg;
            }
            //This fires while the button is pressed down
            if (Input.GetMouseButton(0))
            {
                Vector3 v3 = Input.mousePosition - screenPos;
                float angle = Mathf.Atan2(v3.y, v3.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0, 0, angle + angleOffset);
            }
        }
        else
        {

        }
       
    }
}
