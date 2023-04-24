using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearingBlocks : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Collider2D collider2D;
    private ButtonScript buttonScript;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        collider2D = GetComponent<Collider2D>();
        buttonScript = FindObjectOfType<ButtonScript>();
    }

    void Update()
    {
        if (buttonScript.ButtonSignal)
        {
            spriteRenderer.enabled = false;
            collider2D.enabled = false;
        }
    }
}
