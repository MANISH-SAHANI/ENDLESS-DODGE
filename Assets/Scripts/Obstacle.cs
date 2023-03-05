using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float RotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, RotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);

            FindObjectOfType<GameManager>().gameOver();
        }

        if (collision.gameObject.tag == "ground")
        {
            FindObjectOfType<GameManager>().scoreIncrease();
            Destroy(gameObject);
        }
    }

}
