using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSpawner : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        chain.isFired = false;
        if (collision.CompareTag("Ball"))
        {
            collision.GetComponent<Ball>().split();
        }
        
    }
}
