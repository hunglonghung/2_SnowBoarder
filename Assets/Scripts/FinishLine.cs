using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayTime = 1f;
    [SerializeField] ParticleSystem finishEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("reloadScene",delayTime);     
            //  Debug.Log("Finished!");     
            GetComponent<AudioSource>().Play();  
        }
    }
    void reloadScene()
    {
        SceneManager.LoadScene("Level1");
    }
}
