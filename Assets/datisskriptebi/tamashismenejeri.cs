using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tamashismenejeri : MonoBehaviour
{
    // Start is called before the first frame update
    public int bushtebi;
    int gaberili_bushtebi;

    private bushtebi_vizuali bushtebi_Vizuali;

    public int getGaberili()
    {
        return gaberili_bushtebi;
    }
    public void gaberva()
    {
        if (bushtebi <= 0 || (gaberili_bushtebi >= 3 && GameObject.FindGameObjectWithTag("Player").transform.position.y < 30)) return;

        bushtebi--;
        gaberili_bushtebi++;
        bushtebi_Vizuali.spawnBalloon();
    }
    public void dafushva()
    {
        gaberili_bushtebi--;
    }


    void Start()
    {
        bushtebi_Vizuali = GameObject.FindWithTag("bushtebi").GetComponent<bushtebi_vizuali>();
    }



    public void resetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
