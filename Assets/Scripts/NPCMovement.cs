using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    private float timeLeft;
    [SerializeField] float accelerationTime = 2f;
    [SerializeField] float speed = 1f;
    [SerializeField] float movementRange = 1.5f;
    [SerializeField] float scaleRange = .002f;

    private Vector2 movementDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        transform.localScale = transform.localScale + new Vector3(Random.Range(-scaleRange, scaleRange), Random.Range(-scaleRange, scaleRange), 0);

        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0)
        {
            movementDirection = new Vector2(Random.Range(-movementRange, movementRange), Random.Range(-movementRange, movementRange));
            timeLeft += accelerationTime;
        }

        rb.AddForce(movementDirection * speed);
    }
}
