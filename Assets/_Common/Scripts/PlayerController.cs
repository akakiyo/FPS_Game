using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 1f;

    public int HP = 100;
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
        rb.velocity = movement * moveSpeed;
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "EnemyBullet"){
            Damage(10);
        }
    }

    void Fire()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            bullet.Fire(gameObject, transform.position, Quaternion.identity, transform.parent);
        }
    }

    void Damage(int damage)
    {
        HP -= damage;

        if(HP <= 0)
        {
            //UIManagerのShowResultScreenを呼び出す
            UIManager.instance.ShowResultScreen();
        }
    }
}
