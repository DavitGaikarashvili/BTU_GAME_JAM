using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class tamashismenejeri : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int bushtebi;
    public void addbushti()
    {
        bushtebi_Vizuali.spawnBalloon();
        bushtebi++;
    }
    public void removebushti()
    {
        bushtebi--;
    }
    public int getbushtebi()
    {
        return bushtebi;
    }

    public TMP_Text bushtitext;
    private bushtebi_vizuali bushtebi_Vizuali;
    void Start()
    {
        bushtebi_Vizuali = GameObject.FindWithTag("bushtebi").GetComponent<bushtebi_vizuali>();
    }

    // Update is called once per frame
    void Update()
    {
        bushtitext.text = "bushtebi " + bushtebi.ToString() + " / 3";
    }

    public void resetLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
