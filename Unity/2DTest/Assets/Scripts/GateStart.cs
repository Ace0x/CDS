/*
Andrew Dunkerley, Emiliano Cabrera
Resets the fruits placed on the map when the trophy on the other side is collected it also spawns a trophy on the side opposite to the player's current location
this one doesn't spawn on game Start
*/
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
