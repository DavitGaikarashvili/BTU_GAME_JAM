using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mkvleli : MonoBehaviour
{
    //public int Respawn;
    private tamashismenejeri tm;
    void Start()
    {
        tm = GameObject.FindWithTag("manager").GetComponent<tamashismenejeri>();
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
        }
        if (other.CompareTag("bushti"))
        {
            Destroy(other.gameObject);
            tm.dafushva();
        }
        void die()
        {
            StartCoroutine(respawn(0.5f));
        }
        IEnumerator respawn(float duration)
        {
            yield return new WaitForSeconds(duration);
            tm.resetLevel();
        }
    }
}
