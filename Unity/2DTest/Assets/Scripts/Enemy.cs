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
