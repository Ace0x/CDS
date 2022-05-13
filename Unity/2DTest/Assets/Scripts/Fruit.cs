using UnityEngine;
/*
Andrew Dunkerley, Emiliano Cabrera
Checks if the player collision box touches a fruit to then deactivate the object and add one point to the score
*/
public class Fruit : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ScoreScript.scoreV += 1;
            gameObject.SetActive(false);
        }
    }
   
}
