using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogscrip : MonoBehaviour
{
    private Rigidbody2D _rigg;
    private Animator anima;
    public float veloci;
     void Awake()
    {
        
       _rigg = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();

        
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _rigg.velocity = new Vector2(veloci, _rigg.velocity. y);
    }
}
