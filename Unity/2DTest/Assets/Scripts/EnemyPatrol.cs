using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [Header ("Patrol Points")]
    
    [SerializeField] private Transform lEdge;
    [SerializeField] private Transform rEdge;

    [Header ("Enemy")]
    [SerializeField] private Transform enemy;

    [Header ("Movement")]
    [SerializeField] private float speed;
    private Vector3 initScale;
    private bool movingL;

    [Header ("Anim")]
    [SerializeField]private Animator anim;



    private void Awake()
    {
        initScale = enemy.localScale;
    }
    private void Update()
    {
        if(movingL)
        {
            if(enemy.position.x >= lEdge.position.x)
                MoveInDirection(-1);
            else
                DirectionChange();
            
        }
        else
        {
            if(enemy.position.x <= rEdge.position.x)
                MoveInDirection(1);
            else
                DirectionChange();
            
        }
    }

    private void MoveInDirection(int direction)
    {
        anim.SetBool("moving", true);
        enemy.localScale = new Vector3(Mathf.Abs(initScale.x) * direction, initScale.y, initScale.z);
        enemy.position = new Vector3(enemy.position.x + Time.deltaTime * direction * speed, enemy.position.y, enemy.position.z);

    }

    private void DirectionChange()
    {
        anim.SetBool("moving", false);
        movingL = !movingL;
    }

}
