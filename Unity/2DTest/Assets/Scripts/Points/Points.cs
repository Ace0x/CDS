using UnityEngine;

public class Points : MonoBehaviour
{
    [SerializeField] private float startingPoints;
    private float currentPoints;

    private void Awake()
    {
        currentPoints = startingPoints;
    }

    public void TakeDmg(float dmg)
    {
        currentPoints = Mathf.Clamp(currentPoints - dmg, 0, startingPoints);

        
    }
}
