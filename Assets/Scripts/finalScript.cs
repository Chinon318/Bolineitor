using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            int buildIndex = SceneManager.GetActiveScene().buildIndex;
            if(buildIndex == 3)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                SceneManager.LoadScene(buildIndex + 1);
            }
        }
    }
}
