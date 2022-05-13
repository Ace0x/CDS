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
