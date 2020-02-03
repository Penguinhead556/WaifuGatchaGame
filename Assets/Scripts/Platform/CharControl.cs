using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControl : MonoBehaviour
{
    float speed = 10f;
    float jump = 30f;
    private Rigidbody2D rb;
    protected Joystick joystick;
    public bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        rb = this.GetComponent<Rigidbody2D>();
        grounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        // What is the player doing with the controls?
        Vector3 move = new Vector3(joystick.Horizontal, 0, 0);

        // Update the ships position each frame
        transform.position += move
            * speed * Time.deltaTime;

        if (joystick.Vertical>0.5 && grounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
            grounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.transform.tag == "Ground")
        {
            grounded = true;
        }
    }

}
