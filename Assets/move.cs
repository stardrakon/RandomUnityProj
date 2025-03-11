using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
         if(!(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
        {
            rb.linearVelocityX = 0;
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.linearVelocityX = -5;
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.linearVelocityX = 5;
        }


    }
}
