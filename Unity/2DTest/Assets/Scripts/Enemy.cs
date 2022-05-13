/*
Andrew Dunkerley, Emiliano Cabrera
Detects if the player touches the collision box of an enemy to then deduct 1 point to the total score
*/
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(ScoreScript.scoreV != 0)
                ScoreScript.scoreV -= 1;
            
        }
    } 
}
