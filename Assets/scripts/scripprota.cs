using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scripprota : MonoBehaviour
{
    private Rigidbody2D _comporig;
    public int velocidad;
    private float hori, verti;
    private Animator _anim;
    private SpriteRenderer _sprit;
    public GameObject disparo;
    public float salto;
    public bool detector;
    public bool jum;

    private void Awake()
    {
        _comporig = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
        _sprit = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        caminata();
        tiro();
        if (Input.GetAxis("Vertical") > 0 && detector == true)
        {
            jum = true;
        }
        else
        {
            jum = false;
        }
    }
    private void FixedUpdate()
    {
        _comporig.velocity = new Vector2(hori * velocidad, _comporig.velocity.y );
        if (jum==true)
        {
            _comporig.AddForce(Vector2.up*salto ,ForceMode2D.Impulse) ;
        }
       
       
    }
    public void caminata()
    {
        hori = Input.GetAxis("Horizontal");

        if (hori < 0)
        {
            _sprit.flipX = true;
            _anim.SetBool("run", false);
            if (Input.GetKeyDown("space") == true)
            {
                Instantiate(disparo, transform.position, transform.rotation);
            }
        }
        else if (hori > 0)
        {
            _sprit.flipX = false;
            _anim.SetBool("run", false);
            if (Input.GetKeyDown("space") == true)
            {
                Instantiate(disparo, transform.position, transform.rotation);
            }
        }
        else
        {
            _anim.SetBool("run", true);

        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {

            detector = true;

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "piso")
        {

           detector = false;
        }
    }

    public void tiro()
    {
       
    }


}
