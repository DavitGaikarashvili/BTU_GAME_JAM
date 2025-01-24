using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mkvleli : MonoBehaviour
{
    //public int Respawn;
    public GameObject dd;
    public spawnpoint spauni;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            die();
            dd.SetActive(false);
            
        }
        void die()
        {
            StartCoroutine(respawn(0.5f));
        }
        IEnumerator respawn(float duration)
        {
            yield return new WaitForSeconds(duration);
            dd.transform.position = spauni.transform.position;
            dd.SetActive(true);
        }
    }
}
