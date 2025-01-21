using System;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{
    [SerializeField, Tooltip("How high the obstacle spawns.")]
    private float spawnHeight;

    [SerializeField, Tooltip("How fast the obstacle moves along the x-axis.")]
    private float moveSpeedX;

    private Rigidbody2D rb2d;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        rb2d.linearVelocityX = moveSpeedX;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
