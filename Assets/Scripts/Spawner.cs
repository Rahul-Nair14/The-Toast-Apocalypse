using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Enemy;
    public GameObject[] LessSpawnedObs;
    private float TimebtwSpawn;
    public float StartTimebtwSpawn;
    public float DecreaseTime;
    public float minTime = 0.6f;

    public void Update()
    {
        if(TimebtwSpawn<=0)
        {
            int Rand1 = Random.Range(0, LessSpawnedObs.Length);
            int Rand2 = Random.Range(0, LessSpawnedObs.Length);
            Enemy[Enemy.Length - 1] = LessSpawnedObs[Rand1];
            Enemy[Enemy.Length - 2] = LessSpawnedObs[Rand2];
            int Rand = Random.Range(0, Enemy.Length);
            Instantiate(Enemy[Rand], transform.position,Quaternion.identity);
            TimebtwSpawn = StartTimebtwSpawn;
            if(StartTimebtwSpawn>minTime)
            {
                StartTimebtwSpawn -= DecreaseTime;
            }
        }
        else
        {
            TimebtwSpawn -= Time.deltaTime;
        }
    }

}
