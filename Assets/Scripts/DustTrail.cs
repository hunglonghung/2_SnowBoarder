using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem slidingEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    

    }
    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "crash")
        {
            slidingEffect.Play();
        }
    }
    void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag == "crash")
        {
            slidingEffect.Stop();
        }
        
    }
}
