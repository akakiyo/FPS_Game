using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 1f;
    public GameObject bullet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        Fire();
    }

    void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement * moveSpeed);
    }

    void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject a = Instantiate(bullet, transform.position + new Vector3(0, 0, 3), Quaternion.identity);

            Rigidbody rb = a.GetComponent<Rigidbody>();
            rb.AddForce(a.transform.forward * 1000); // 力の大きさは調整してください
        }
    }
}
