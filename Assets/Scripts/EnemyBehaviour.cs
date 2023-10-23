using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehaviour : MonoBehaviour
{
    Transform playerTransform;
    [SerializeField] float speed = 0.005f;

    Transform player;

    private void Update()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        FollowPlayer();
    }
    
    void FollowPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerTransform.transform.position, speed * Time.timeScale);
    }
}
