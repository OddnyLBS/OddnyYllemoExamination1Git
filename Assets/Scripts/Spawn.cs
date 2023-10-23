using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject[] objects;

    [SerializeField] float distY;
    [SerializeField] float distX;

    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        InvokeRepeating("Spawner", 1, 1f);
    }

    void Spawner()
    {
        Vector3 playerPosition = player.transform.position;
        int randomSpawn = Random.Range(0, spawnPoints.Length);
        Vector3 randomSpawnPoint = spawnPoints[randomSpawn].position;

        float playerDist = Vector3.Distance(playerPosition, randomSpawnPoint);

        if (playerDist >= distY && playerDist >= distX)
        {
            Instantiate(objects[Random.Range(0, objects.Length)], randomSpawnPoint, Quaternion.identity);
        }
    }
}
