using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour

{
    public float jumpForce = 10f;

    public Rigidbody2D rb;

    public string currentcolor;

    


    void Start()
    {
        SetRandomColor();
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log(col.tag);
    }

    void SetRandomColor()
    {
        int index = Random.Range(0, 3);

        switch (index)
        {
            case 0:
                currentcolor = "cyan";
                break;
            case 1:
                currentcolor = "yellow";
                break;
            case 2:
                currentcolor = "magenta";
                break;
            case 3:
                currentcolor = "pink";
                break;
        }
    }
}



    
     

    

