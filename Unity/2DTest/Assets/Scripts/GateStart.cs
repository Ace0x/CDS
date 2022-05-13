using UnityEngine;

public class GateStart : MonoBehaviour
{
    private GameObject gateEnd;
    private GameObject [] fruits;
 
  

    void Start () 
    {
        fruits = GameObject.FindGameObjectsWithTag("Fruit");
        gateEnd = GameObject.FindGameObjectWithTag("GateEnd");
        gameObject.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ScoreScript.scoreV += 10;
            gameObject.SetActive(false);
            foreach(GameObject f in fruits)
            {
                f.SetActive(true);
            }
            gateEnd.SetActive(true);
            
           
            
        }
    }

    
   
}
