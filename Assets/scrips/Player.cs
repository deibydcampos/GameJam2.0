using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D myRig;
    public float speed;
    public float jump;
    private bool saltar;
    private float horizontal;
    
    void Start()
    {
        myRig = GetComponent<Rigidbody2D>();
        
    }

   
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        myRig.velocity = new Vector2(horizontal*speed, myRig.velocity.y);
        if (Input.GetButtonDown("Jump")&&saltar==true)
        {
            myRig.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
    if (other.gameObject.tag == "Piso")
    {
        saltar = true;
    }

    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Piso")
        {
            saltar = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            
            Destroy(this.gameObject);
            
        }
    }
   
}
