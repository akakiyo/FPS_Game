using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 1f;
    public BulletController bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    void FixedUpdate() {
        MovePlayer();
    }

    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Rigidbody rb = GetComponent<Rigidbody>();
        // rb.AddForce(movement * moveSpeed);
        rb.velocity = movement * moveSpeed;
    }

    void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bullet.Fire(gameObject.tag, transform.position, Quaternion.identity);
        }
    }
}
