using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushti_line : MonoBehaviour
{
    LineRenderer lr;
    private GameObject player;
    private Rigidbody2D playerrb;
    Vector3 direction;
    Vector3 startpos;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.localPosition;
        lr = GetComponent<LineRenderer>();
        player = GameObject.FindWithTag("Player");
        playerrb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Make the balloon follow 
        if ((playerrb.velocity * Vector3.right).magnitude > 0.1f)
        {
            float velocity_direction = playerrb.velocity.normalized.x;
            transform.localPosition = startpos * velocity_direction + 0.5f * velocity_direction * Vector3.left;
        }
        else
        {
            transform.localPosition = startpos;
        }

        transform.rotation = Quaternion.LookRotation(Vector3.forward, (transform.position - player.transform.position).normalized);

        lr.SetPosition(0, transform.position);
        lr.SetPosition(1, player.transform.position);
        lr.startColor = Color.Lerp(Color.white, Color.gray, 0.5f);
        lr.startColor = Color.Lerp(Color.white, Color.gray, 0.5f);
    }
}
