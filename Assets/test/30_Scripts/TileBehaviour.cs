using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileBehaviour : MonoBehaviour {

    const string snake = "Snake";

    public Material colorBeforeCollision, colorAfterCollision;
    private new Renderer renderer;
    // Use this for initialization
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.enabled = true;
        
    }

    private void OnTriggerEnter(Collider col)
    {

       if(col.gameObject.tag.Equals(snake))
        {
            renderer.material = colorAfterCollision;
        }

    }
}
