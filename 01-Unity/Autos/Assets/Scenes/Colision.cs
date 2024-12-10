using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.5f;
    private bool hasPackage;
    private SpriteRenderer _spriteRenderer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Golpeee");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log("Entrando a trigger");
        if (other.tag == "Paquete" && !hasPackage)
        {
            Debug.Log("Recojo paquete");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Cliente" && hasPackage)
        {
            Debug.Log("Dejo paquete");
            hasPackage = false;
            _spriteRenderer.color = Color.green;
        }
    }
}
