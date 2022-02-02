using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem finishEffect;
    float loadDelay = 0.5f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("you finished");
            finishEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }
    
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
