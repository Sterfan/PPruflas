using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindDamage1 : MonoBehaviour
{
    private int damagetaken = 4;


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "WaterEnemy")
        {
            other.gameObject.GetComponent<HPManagerWaterEnemy>().TakingDamage(damagetaken);
        }
        else if (other.gameObject.tag == "FireEnemy" + "EarthEnemy" + "WindEnemy")
        {
            damagetaken = 1;
        }
    }
}
