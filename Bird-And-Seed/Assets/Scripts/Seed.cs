using System.Runtime.CompilerServices;
using UnityEngine;

public class Seed : MonoBehaviour
{
    [SerializeField]
    private Sprite[] sprites;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();

        sr.sprite = sprites[Random.Range(0, sprites.Length)];
    }
}
