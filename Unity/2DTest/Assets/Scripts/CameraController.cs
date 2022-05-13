using UnityEngine;
/*
Andrew Dunkerley, Emiliano Cabrera
Handles player camera movement by following the player and looking a small distance ahead in either direction
*/
public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPositionX;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform player;
    [SerializeField] private float distanceAhead;
    [SerializeField] private float camSpeed;
    private float lookAhead;
    
    private void Update()
    {
        
        transform.position = new Vector3(player.position.x + lookAhead,transform.position.y,transform.position.z);
        lookAhead = Mathf.Lerp(lookAhead, (distanceAhead * player.localScale.x), Time.deltaTime * camSpeed);
    }

    public void MoveNewRoom(Transform newRoom)
    {
        currentPositionX = newRoom.position.x;

    }

}

