using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDamage : MonoBehaviour
{
    private int damagetaken = 4;


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "FireEnemy")
        {
            other.gameObject.GetComponent<HPManagerFireEnemy>().TakingDamage(damagetaken);
        }
        else if (other.gameObject.tag == "EarthEnemy" + "WaterEnemy" + "WindEnemy")
        {
            damagetaken = 1;
        }
    }
}


    



    


