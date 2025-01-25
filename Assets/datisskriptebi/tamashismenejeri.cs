using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class tamashismenejeri : MonoBehaviour
{
    // Start is called before the first frame update
    public int bushtebi;
    public TMP_Text bushtitext;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bushtitext.text = "bushtebi " + bushtebi.ToString() + " / 3";
    }
}
