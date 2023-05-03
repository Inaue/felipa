using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorDeDificuldades : MonoBehaviour
{
    [SerializeField] private float tmp_gerar;
    [SerializeField] private GameObject obs;
    private float khronos;

    void Awake()
    {
        this.khronos    = this.tmp_gerar;
    }

    // Update is called once per frame
    void Update()
    {
        this.khronos    -= Time.deltaTime;

        if(this.khronos < 0)
        {
            GameObject.Instantiate(this.obs, this.transform.position, Quaternion.identity);
            this.khronos    = this.tmp_gerar;
        }
    }
}
