using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infoscript : MonoBehaviour
{
    public float timeRemaining = 2;
    public AudioClip infoclip;
    public AudioSource infosource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            PlaySound(infoclip);
        }
        if (timeRemaining <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void PlaySound(AudioClip clip)
    {
        infosource.PlayOneShot(clip);
    }
}
