using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllyBehaviour : MonoBehaviour
{
    [SerializeField] float minScaleX = 0.5f;
    [SerializeField] float maxScaleX = 5f;

    [SerializeField] float minScaleY = 0.5f;
    [SerializeField] float maxScaleY = 5f;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);

            if (transform.localScale.x <= maxScaleX && transform.localScale.y <= maxScaleY)
            {
                transform.localScale += new Vector3(.5f, .5f, 0);
            }
        }

        if (other.gameObject.tag == "Antidote")
        {
            Destroy(other.gameObject);

            if (transform.localScale.x >= minScaleX && transform.localScale.y >= minScaleY)
            {
                transform.localScale -= new Vector3(.5f, .5f, 0);
            }
        }
    }
}
