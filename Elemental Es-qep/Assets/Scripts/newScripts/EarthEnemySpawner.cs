using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthEnemySpawner : MonoBehaviour
{
    public enum SpawnState { Spawning, Wait, Counting };

    [System.Serializable]

    public class Wave
    {
        public string name;
        public Transform enemy;
        public int amount;
        public float rate;
    }

    public Wave[] Waves;

    public Transform[] spawnPoints;

    private int nextWave = 0;

    public float waveDelay = 6f;
    public float waveCountdown;

    private float enemySearchCountdown = 3f;

    private SpawnState state = SpawnState.Counting;

    void Start()
    {

        waveCountdown = waveDelay;

    }


    void Update()
    {
        if (state == SpawnState.Wait)
        {
            if (EnemyAlive() == false)
            {

                WaveCompleted();
            }
            else
            {
                return;
            }
        }

        if (waveCountdown <= 0)
        {
            if (state != SpawnState.Spawning)
            {
                StartCoroutine(SpawnWave(Waves[nextWave]));
            }
        }
        else
        {
            waveCountdown -= Time.deltaTime;
        }
    }

    void WaveCompleted()
    {
        Debug.Log("Wave done");

        state = SpawnState.Counting;
        waveCountdown = waveDelay;
        if (nextWave + 1 > Waves.Length - 1)
        {
            nextWave = 0;

            Debug.Log("Waves Complete! Looping...");
        }
        else
        {
            nextWave++;
        }

    }

    bool EnemyAlive()
    {
        enemySearchCountdown -= Time.deltaTime;
        if (enemySearchCountdown <= 0f)
        {
            enemySearchCountdown = 1.5f;

            if (GameObject.FindGameObjectWithTag("EarthEnemy") == null)
            {
                return false;
            }


        }
        return true;
    }

    IEnumerator SpawnWave(Wave _wave)
    {
        //Debug.Log("Spawning a wave:" + _wave.name);

        state = SpawnState.Spawning;
        for (int i = 0; i < _wave.amount; i++)
        {
            SpawnEnemy(_wave.enemy);
            yield return new WaitForSeconds(1f / _wave.rate);
        }

        state = SpawnState.Wait;

        yield break;
    }

    void SpawnEnemy(Transform _enemy)

    {

        //Debug.Log("Spawning" + _enemy.name);

        Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
        Instantiate(_enemy, _sp.position, _sp.rotation);
    }
}
