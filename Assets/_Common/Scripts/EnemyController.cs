using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet;
    public GameObject player;
    public float attackInterval = 1;
    public float attackTimer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(attackTimer);
        if(attackInterval <= attackTimer)
        {
           Fire();
           attackTimer = 0;
        }
        attackTimer += Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet"){
            Destroy(gameObject);
        }
    }

    void Fire()
    {
        Vector3 directionToPlayer = player.transform.position - transform.position;
        Quaternion rotationTowardsPlayer = Quaternion.LookRotation(directionToPlayer);
        GameObject a = Instantiate(bullet, transform.position + new Vector3(0,0,-3), rotationTowardsPlayer);

        Rigidbody rb = a.GetComponent<Rigidbody>();
        rb.AddForce(a.transform.forward * 1000); // 力の大きさは調整してください

    }
}
