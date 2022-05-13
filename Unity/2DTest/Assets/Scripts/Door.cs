using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform prevRoom;
    [SerializeField] private Transform nextRoom;
    private CameraController cam;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(collision.transform.position.x < transform.position.x)
                cam.MoveNewRoom(nextRoom);
            
            else
                cam.MoveNewRoom(prevRoom);
        }
    }
    private void Awake()
    {
        cam = Camera.main.GetComponent<CameraController>();
    }
   
}
