using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private PlayerMovement player;
    private Rigidbody2D rb;
    private Vector2 movement;
    // Start is called before the first frame update
    void Awake()
    {
        player = FindAnyObjectByType<PlayerMovement>();
        rb = GetComponent<Rigidbody2D>();
        movement = Camera.main.ScreenToWorldPoint(Input.mousePosition) - player.transform.position;
        movement.Normalize();
        rb.velocity = movement * speed;
    }

    // Update is called once per frame
    void Update()
    {
   
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
