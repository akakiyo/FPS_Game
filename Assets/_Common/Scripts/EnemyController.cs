using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // Start is called before the first frame update
    public BulletController bullet;
    public float attackInterval = 1;
    public float attackTimer = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(attackInterval <= attackTimer)
        {
            Fire();
            attackTimer = 0;
        }
        attackTimer += Time.deltaTime;
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "PlayerBullet"){
            Destroy(gameObject);
            GameManager.instance.score++;
        }
    }

    void Fire()
    {
        GameObject player = GameObject.FindWithTag("Player");
        Vector3 directionToPlayer = player.transform.position - transform.position;
        Quaternion rotationTowardsPlayer = Quaternion.LookRotation(directionToPlayer);
        bullet.Fire(gameObject.tag, transform.position, rotationTowardsPlayer);
    }
}
