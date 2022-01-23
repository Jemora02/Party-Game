using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timerscript : MonoBehaviour
{
    public Player Player;
    public Text timer;
    public float timeRemaining = 12;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timer.text = timeRemaining.ToString();
        }
        if (timeRemaining <= 0)
        {
            Player.loseTextObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        if (Player.scoreValue >= 9)
        {
            timeRemaining += Time.deltaTime;
        }
    }
}
