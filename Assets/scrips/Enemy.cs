using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D Myrig;
    public float speed;
    public GameObject menu, boton;
    void Start()
    {
        Myrig = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        StartCoroutine(IniciarCorutina());
    }
    
    IEnumerator IniciarCorutina()
    {
        yield return new WaitForSeconds(1f);
        Myrig.velocity = new Vector2(speed, Myrig.velocity.y);
    }
    IEnumerator Resetearmenu()
    {
        yield return new WaitForSeconds(1f);
        Time.timeScale = 0;
        menu.SetActive(true);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            boton.SetActive(false);
            speed = 0;
            StartCoroutine(Resetearmenu());
        }
    }
}
