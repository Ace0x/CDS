/*
Andrew Dunkerley, Emiliano Cabrera
Resets the fruits placed on the map when the trophy on the other side is collected it also spawns a trophy on the side opposite to the player's current location
*/
using UnityEngine;

public class GateEnd : MonoBehaviour
{
    
    private GameObject [] fruits;
    private GameObject gateStart;
 
  

    void Start () 
    {
        fruits = GameObject.FindGameObjectsWithTag("Fruit");
        gateStart = GameObject.FindGameObjectWithTag("GateStart");
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
            gateStart.SetActive(true);
             
        }
    }
   
}
