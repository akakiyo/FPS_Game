using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float bulletSpeed = 100;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
    public void Fire(GameObject character,Vector3 position, Quaternion rotation, Transform parent = null)
    {
        Vector3 dir = Vector3.zero;
        switch (character.tag)
        {
            case "Player":
                dir = new Vector3(0, 0, 3);
                break;
            case "Enemy":
                dir = new Vector3(0, 0, -3);
                break;
        }
        GameObject bullet = Instantiate(gameObject, position + dir, rotation, parent);
        bullet.tag = character.tag + "Bullet";

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(bullet.transform.forward * bulletSpeed);
    }
}
