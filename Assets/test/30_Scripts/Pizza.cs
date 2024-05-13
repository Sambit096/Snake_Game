using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour {

    public int scoreIncrement;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Snake"))
        {
            Scoring.instance.IncreaseScore(scoreIncrement);
            Destroy(this.gameObject);
        }
        
    }
}
