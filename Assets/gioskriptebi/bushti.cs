using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushti_line : MonoBehaviour
{
    LineRenderer lr;
    private GameObject player;
    Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        player = GameObject.FindWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        //Make the balloon follow slowly
        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, player.transform.position);
        lr.startColor = Color.Lerp(Color.white, Color.gray, 0.5f);
        lr.startColor = Color.Lerp(Color.white, Color.gray, 0.5f);
    }
}
