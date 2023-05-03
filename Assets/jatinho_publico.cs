using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jatinho_publico : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField] private float vel;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            this.Impulsionar();
        }
    }

    private void Impulsionar()
    {
        this.fisica.AddForce(Vector2.up * this.vel, ForceMode2D.Impulse);
    }
}
