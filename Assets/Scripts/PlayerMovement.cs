using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject bullet;
    private Rigidbody2D rb;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        calcDirection();
        rb.velocity = direction * speed;
        if (Input.GetMouseButtonDown(0))
            createBullet();
    }

    void calcDirection()
    {
        direction = Vector2.zero;
        direction += Input.GetKey(KeyCode.W) ? new Vector2(0, 1) : new Vector2(0, 0);
        direction += Input.GetKey(KeyCode.S) ? new Vector2(0, -1) : new Vector2(0, 0);
        direction += Input.GetKey(KeyCode.D) ? new Vector2(1, 0) : new Vector2(0, 0);
        direction += Input.GetKey(KeyCode.A) ? new Vector2(-1, 0) : new Vector2(0, 0);
    }

    public void createBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
