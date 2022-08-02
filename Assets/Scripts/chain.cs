using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chain : MonoBehaviour
{
    public static bool isFired;
    public Transform player;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        isFired = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            isFired = true;
        }
        if (isFired)
        {
            transform.localScale += Vector3.up * Time.deltaTime * speed ;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(0.4f, 0f, 1f);
        }
    }
}
