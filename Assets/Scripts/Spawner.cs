using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float timer = 25f;
    private float currentTime;
    public GameObject enemy;
    public GameObject[] spawners;
    private int index;

    private void Start()
    {
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        currentTime = timer;
    }

    public void Update()
    {

        currentTime -= Time.deltaTime;

        if (currentTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        //do your stuff here.
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        index = Random.Range(0, spawners.Length);
        Instantiate(enemy, spawners[index].transform.position, spawners[index].transform.rotation);
        currentTime = timer;
    }


}

