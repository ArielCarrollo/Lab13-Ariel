using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalmove : MonoBehaviour
{
    public float Speed = 4;
    public int DirectionX = 0;
    public float DirectionY = 1;
    private Rigidbody2D _compRigidbody2D;
    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Robot")
        {
            Destroy(this.gameObject);
        }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(DirectionX * Speed, DirectionY * Speed);
    }
}
