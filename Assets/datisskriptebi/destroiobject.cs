using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroiobject : MonoBehaviour
{


    // For triggers
    public void OnTriggerEnter2D(Collider2D other)
    {
        // Destroy this game object when it enters a trigger
        Destroy(gameObject);
    }

}
