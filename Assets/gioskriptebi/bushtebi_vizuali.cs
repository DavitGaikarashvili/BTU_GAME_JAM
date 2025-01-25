using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bushtebi_vizuali : MonoBehaviour
{
    [SerializeField] GameObject Balloon;
    [SerializeField] tamashismenejeri GameManager;

    public void spawnBalloon()
    {
        GameObject spawned = Instantiate(Balloon, transform.position, transform.rotation);
        spawned.GetComponent<SpriteRenderer>().color = Random.ColorHSV();
        Color lightColor = Random.ColorHSV(0, 1, 0.5f, 1, 0.9f, 1);
        spawned.GetComponent<SpriteRenderer>().color = lightColor;
        spawned.transform.SetParent(transform);
        spawned.transform.localPosition = new Vector3(Random.Range(-0.25f, 0.25f), 0, 0);
    }
}
