using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem playerEffect;
    bool playedAlready = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "crash")
        {
            FindObjectOfType<PlayerController>().disableControl();
            if(!playedAlready)
            {
                playerEffect.Play();
                Invoke("reloadScene",delayTime);
                // Debug.Log("Crashed!");
                GetComponent<AudioSource>().Play();
                playedAlready = true;
            }
            
        }
        
    }
    void reloadScene()
    {
        SceneManager.LoadScene("Level1");
        Debug.Log("Crashed!Reset!");
    }
}
