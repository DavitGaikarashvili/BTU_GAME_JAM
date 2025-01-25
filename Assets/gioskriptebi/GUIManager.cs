using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GUIManager : MonoBehaviour
{
    tamashismenejeri tm;
    [SerializeField] TMP_Text gasaberi;
    [SerializeField] TMP_Text gaberili;


    // Start is called before the first frame update
    void Start()
    {
        tm = GameObject.FindGameObjectWithTag("manager").GetComponent<tamashismenejeri>();

    }

    // Update is called once per frame
    void Update()
    {
        gasaberi.text = tm.bushtebi.ToString();
        gaberili.text = tm.getGaberili().ToString() + " / 3";
    }
}
