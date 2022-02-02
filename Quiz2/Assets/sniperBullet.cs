using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sniperBullet : MonoBehaviour
{
    public float speed=100;
    private Rigidbody bulletRB;
    float damage = 40;
    // Start is called before the first frame update
    void Start()
    {
        bulletRB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

        
    }
    
}
