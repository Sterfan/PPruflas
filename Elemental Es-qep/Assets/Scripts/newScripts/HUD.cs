using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Sprite[] bulletSprites;

    public Image BulletUI;

    private Shooting bullets;


    void Start()
    {
        //bullets = GameObject.FindGameObjectWithTag("Firebullet").GetComponent<Shooting>();
        //bullets = GameObject.FindGameObjectWithTag("Windbullet").GetComponent<Shooting>();
        //bullets = GameObject.FindGameObjectWithTag("Waterbullet").GetComponent<Shooting>();
        //bullets = GameObject.FindGameObjectWithTag("Earthbullet").GetComponent<Shooting>();

    }

    void Update()
    {
        BulletUI.sprite = bulletSprites[Shooting.currentBullet]; 
    }
}
