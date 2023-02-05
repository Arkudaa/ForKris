using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageNPC : MonoBehaviour
{
    public int health;
    public GameObject lastsmoke;
    // Start is called before the first frame update
    void Start()
    {
        health = 100;
    }

    public void GotHit()
    {
        health -= 25;
    }

    public void elimination()
    {
        GameObject Smoke = Instantiate(lastsmoke, transform.position, Quaternion.identity);
        Destroy(Smoke, 1);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0) elimination();
        
    }
}
