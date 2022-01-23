using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Target e = other.collider.GetComponent<Target>();
        if (e != null)
        {
            e.Fix();
            
        }
        Destroy(gameObject);
    }
}
