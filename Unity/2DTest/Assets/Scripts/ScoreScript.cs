/*
Andrew Dunkerley, Emiliano Cabrera
updates the text object that shows the score
*/
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
