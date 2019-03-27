using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorChange : MonoBehaviour
{

    private SpriteRenderer spriteRenderer; 
    public Sprite ShipFire;
    public Sprite ShipEarth;
    public Sprite ShipWind;
    public Sprite ShipWater;
    public static int spriteVersion = 0;

    public Sprite[] sprites = new Sprite[4];

    void Start()
    {

        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        sprites[0] = ShipFire;
        sprites[1] = ShipEarth;
        sprites[2] = ShipWind;
        sprites[3] = ShipWater;

    }

    void Update()
    {
        Debug.Log(sprites[spriteVersion].name);

        if (Input.GetMouseButtonDown(1))
        {
            spriteVersion++;
            if (spriteVersion > 3)
                spriteVersion = 0;
            spriteRenderer.sprite = sprites[spriteVersion];

        }

        
    }
}
