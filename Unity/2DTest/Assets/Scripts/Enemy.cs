using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask playerLayer;
    [SerializeField] private float range;
    [SerializeField] private float colliderDistance;
    private void OnTriggerEnter2D(Collider collision)
    {
        if(collision.tag == "Player")
        {
            if(ScoreScript.scoreV != 0)
                ScoreScript.scoreV -= 1;
            
        }

    }

    
}
