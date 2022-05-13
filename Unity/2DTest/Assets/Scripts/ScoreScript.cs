using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public static int scoreV  = 0;
    Text score;

    private void Start()
    {
        score = GetComponent<Text>();

    }
    private void Update()
    {
        score.text = "Score: " + scoreV;
    }
}
