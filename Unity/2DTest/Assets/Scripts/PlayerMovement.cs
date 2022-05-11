using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    private Animator anim;
    private BoxCollider2D boxCollider;
    [SerializeField] private float speed;
    [SerializeField] private LayerMask groundLayer;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //Inputs
        if(horizontalInput > 0.01f)
            transform.localScale = Vector3.one; 
        
        else if(horizontalInput < -0.01f)    
            transform.localScale = new Vector3(-1,1,1); 
    
        if(Input.GetKey(KeyCode.Space) && isGrounded())
            Jump();

        //anims
        anim.SetBool("Run", horizontalInput != 0);
        anim.SetBool("Grounded", isGrounded());
       
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
        anim.SetTrigger("Jump");
        
    }

    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }
   
}

