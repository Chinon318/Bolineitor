using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour
{

    public Rigidbody rb;
    public float forwardSpeed;
    public float sideForce;
    int halfScreen;
    void Start()
    {
        halfScreen = Screen.width /2;
    }

    
    void Update()
    {
        rb.AddForce(new Vector3(0,0,forwardSpeed)*Time.deltaTime);

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(-sideForce,0,0)*Time.deltaTime);
        }
        
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(sideForce,0,0)*Time.deltaTime);
        }
        if(Input.touchCount > 0)
        {
            if(Input.GetTouch(0).position.x <= halfScreen)
            {
                rb.AddForce(new Vector3(-sideForce,0,0)*Time.deltaTime);
            }
            if(Input.GetTouch(0).position.x > halfScreen)
            {
                rb.AddForce(new Vector3(sideForce,0,0)*Time.deltaTime);
            }
        }
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
