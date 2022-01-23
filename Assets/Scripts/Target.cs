using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public  Player Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fix()
    {
        Player.scoreValue += 1;
        Player.score.text = Player.scoreValue.ToString();
        Destroy(gameObject);
    }
}
