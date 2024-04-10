using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb2d;
    [SerializeField] float torqueValue = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float normalSpeed = 20f;
    SurfaceEffector2D sf2d;
    [SerializeField] bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        sf2d = FindObjectOfType<SurfaceEffector2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            controller();
            boostUp();
        }
        
    }
    public void disableControl()
    {
        canMove = false;
    }
    void boostUp()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            sf2d.speed = boostSpeed;
        }
        else sf2d.speed = normalSpeed;
    }

    void controller()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueValue);

        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueValue);
        }
    }
}
