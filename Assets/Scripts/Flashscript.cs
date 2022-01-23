using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashscript : MonoBehaviour
{
    public float displayTime = 4.0f;
    float timerDisplay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}

