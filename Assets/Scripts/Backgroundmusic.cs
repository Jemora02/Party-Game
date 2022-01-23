using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Backgroundmusic : MonoBehaviour
{
    public Player Player;
    public Timerscript Timerscript;
    public AudioSource audioSource;
    public AudioClip BGM;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySound(BGM);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.scoreValue >= 9)
        {
            audioSource.Stop();
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (Player.ammoValue <= 0)
        {
            audioSource.Stop();
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (Timerscript.timeRemaining <= 0)
        {
            audioSource.Stop();
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    public void PlaySound(AudioClip clip)
    {

        audioSource.PlayOneShot(clip);
    }
}
