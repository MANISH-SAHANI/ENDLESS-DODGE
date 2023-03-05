using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sp;
    public float speed;

    // Awake is used to initialize the variable
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Return's true till left mouse button is pressed
        if(Input.GetMouseButton(0))
        {
  
            if(Input.mousePosition.x<Screen.width/2)
            {
                //left
                rb.velocity = Vector2.left * speed;
                sp.flipX = true;
            }
            else
            {
                //right
                rb.velocity = Vector2.right * speed;
                sp.flipX = false;
            }
        }
        
    }
}
