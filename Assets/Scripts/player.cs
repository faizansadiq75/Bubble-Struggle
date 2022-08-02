using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    private float speed = 10f;
    private float x;
   
    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxisRaw("Horizontal");
        transform.position += new Vector3(speed * x * Time.deltaTime,0f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<xyz>().endGame();
        }
    }

}
