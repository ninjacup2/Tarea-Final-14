using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    public GameObject explosi�n;
    public float tiempoDestrucci�n = 2f;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bala")
        {
            GameObject nuevaExplosi�n = Instantiate(explosi�n, transform.position, transform.rotation);
            Destroy(nuevaExplosi�n, tiempoDestrucci�n);
            Destroy(gameObject);
        }
    }
}
