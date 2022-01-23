using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject playerGameObject;
    public GameObject loseTextObject;
    public GameObject winTextObject;
    public GameObject projectilePrefab;
    public GameObject rules;
    public AudioClip Fire;
    public AudioSource fireSource;
    public Text score;
    public Text ammo;
    public ParticleSystem flash;
    public float displayTime = 2.0f;
    
    float timerDisplay;
    public int scoreValue = 0;
    public int ammoValue = 20;
    Rigidbody2D rigidbody2d;


    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        score.text = scoreValue.ToString();
        ammo.text = ammoValue.ToString();
        winTextObject.SetActive(false);
        loseTextObject.SetActive(false);
        rules.SetActive(true);
        timerDisplay = -1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
     float h = Input.GetAxis("Mouse X");
     float v = Input.GetAxis("Mouse Y");
     playerGameObject.transform.Translate(h, v, 0);

     if (Input.GetMouseButtonDown(0))
     {
         Launch();
     }
     if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
     if (scoreValue >= 9)
        {
            winTextObject.SetActive(true);
            rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
            Destroy(gameObject);
            
            
            

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    if (ammoValue <= 0)
        {
            loseTextObject.SetActive(true);
            rigidbody2d.constraints = RigidbodyConstraints2D.FreezeAll;
            Destroy(gameObject);
            

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    if (ammoValue <= 10)
        {
        }
    if (timerDisplay >= 0)
        {
            timerDisplay -= Time.deltaTime;
            if (timerDisplay < 0)
            {
                rules.SetActive(false);
            }
        }
    }
    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position, Quaternion.identity);
        Instantiate(flash, rigidbody2d.position, Quaternion.identity);
        Projectile projectile = projectileObject.GetComponent<Projectile>();
        ammoValue -= 1;
        ammo.text = ammoValue.ToString();

        PlaySound(Fire);

    }
    public void PlaySound(AudioClip clip)
    {
        fireSource.PlayOneShot(clip);
    }
    public void DisplayRules()
    {
        timerDisplay = displayTime;
        rules.SetActive(true);
    }
    public void ChangeAmmo(int amount)
    {
        if (amount < 0)
        {
            Instantiate(flash, transform.position + Vector3.up * 0.5f, Quaternion.identity);
            
        }
    }
}
