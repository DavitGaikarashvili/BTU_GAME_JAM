using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iqitaqetsiaruli : MonoBehaviour
{
    public Transform posA, posB;
    public int speed;
    private Vector2 targetPos;
    private SpriteRenderer spriteRenderer; // Reference to the SpriteRenderer

    void Start()
    {
        targetPos = posB.position;
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component
    }

    void Update()
    {
        // Check if close to posA or posB and switch target
        if (Vector2.Distance(transform.position, posA.position) < 0.1f)
        {
            targetPos = posB.position;
        }
        if (Vector2.Distance(transform.position, posB.position) < 0.1f)
        {
            targetPos = posA.position;
        }

        // Move the object toward the target position
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        // Flip the sprite based on direction
        Vector2 direction = (targetPos - (Vector2)transform.position).normalized;
        if (direction.x > 0) // Moving right
        {
            spriteRenderer.flipX = false; // Default facing right
        }
        else if (direction.x < 0) // Moving left
        {
            spriteRenderer.flipX = true; // Flip to face left
        }
    }
}
