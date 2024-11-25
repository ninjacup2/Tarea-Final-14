using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocidadEnemigo : MonoBehaviour
{
    public Rigidbody2D Nave;
    public float Velocity = -2f;
    // Start is called before the first frame update
    void Awake()
    {
        Nave = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        Nave.velocity = new Vector2(0, Velocity);
    }
}
