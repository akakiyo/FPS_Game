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
    public void Fire(string tag,Vector3 position, Quaternion rotation)
    {
        Vector3 dir = Vector3.zero;
        switch (tag)
        {
            case "Player":
                dir = new Vector3(0, 0, 3);
                break;
            case "Enemy":
                dir = new Vector3(0, 0, -3);
                break;
        }
        GameObject bullet = Instantiate(gameObject, position + dir, rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(bullet.transform.forward * bulletSpeed);
    }
}
