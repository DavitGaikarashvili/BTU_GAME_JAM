using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mkvleli : MonoBehaviour
{
    //public int Respawn;
    public GameObject dd;
    public spawnpoint spauni;
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
            dd.SetActive(false);

        }
        if (other.CompareTag("bushti"))
        {
            Destroy(other.gameObject);
            tm.removebushti();
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
