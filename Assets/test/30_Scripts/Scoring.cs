using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Scoring : MonoBehaviour {
    public static Scoring instance = null;
    public TextMeshPro text;
    private int score = 0;
    bool isGameOver = false;
    private void Start()
    {
        if(instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseScore(int _score)
    {
        score += _score;
    }
    private void FixedUpdate()
    {
        text.text = "The score is " + score;
    }


}
