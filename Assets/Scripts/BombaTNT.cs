using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaTNT : MonoBehaviour
{
    [SerializeField]
    private GameObject BarrilTNT;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D outro)
    {
        if (outro.gameObject.CompareTag("bola"))
        {
            Instantiate(BarrilTNT, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
        }
                      
    }
}