using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireDamage : MonoBehaviour
{
    private int damagetaken = 4;


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "EarthEnemy")
        {
            other.gameObject.GetComponent<HPManagerEarthEnemy>().TakingDamage(damagetaken);
        }
        else if (other.gameObject.tag == "FireEnemy" + "WaterEnemy" + "WindEnemy")
        {
            damagetaken = 1;
        }
    }
}
