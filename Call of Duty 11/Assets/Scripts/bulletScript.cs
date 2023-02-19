using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{
    public GameObject explosion;
    private float health;
    // Start is called before the first frame update
    void Start()
    {
        health = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            Instantiate(explosion, transform.position, Quaternion.identity);
            health--;
            if (health <= 0) Application.LoadLevel(Application.loadedLevel);
           
        }
    }
}
