using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthDamage : MonoBehaviour
{
    private int damagetaken = 4;


    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "WindEnemy")
        {
            other.gameObject.GetComponent<HPManagerWindEnemy>().TakingDamage(damagetaken);
        }
        else if (other.gameObject.tag == "EarthEnemy" + "WaterEnemy" + "FireEnemy")
        {
            damagetaken = 1;
        }
    }
}
