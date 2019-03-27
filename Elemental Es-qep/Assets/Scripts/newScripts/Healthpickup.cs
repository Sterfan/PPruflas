
using UnityEngine;

public class Healthpickup : MonoBehaviour
{
    HealthManagerPlayer playerHealth;

    public float healthPickUp = 4f;
    float deleteTime = 3f;

    void Awake()
    {
        playerHealth = FindObjectOfType<HealthManagerPlayer>();

    }


    void OnTriggerEnter2D()
    {
        Destroy(gameObject);
        if (playerHealth.currentHealth < playerHealth.maxHealth)
        {
            //Destroy(gameObject);
            playerHealth.currentHealth = playerHealth.currentHealth + healthPickUp;
        }
        FindObjectOfType<AudioManager>().Play("UpgradeHealth");
    }

    void Update()
    {
        deleteTime -= Time.deltaTime;

        if (deleteTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
