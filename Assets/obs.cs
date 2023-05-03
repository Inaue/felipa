using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obs : MonoBehaviour
{
    [SerializeField] private float vel;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * this.vel);
    }
}
