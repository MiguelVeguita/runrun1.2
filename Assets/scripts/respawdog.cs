using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawdog : MonoBehaviour
{
    public GameObject _dog,bala;

   
    void Start()
    {
        Invoke("CAN", 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void CAN()
    {
        Invoke("CAN", 3);
        Vector2 posi = new Vector2(transform.position.x, transform.position.y);
        Instantiate(_dog, posi, transform.rotation);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="balita")
        {
            Destroy(this.gameObject);
        }
                

        
    }
}
