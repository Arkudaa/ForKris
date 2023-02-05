using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manageCollision : MonoBehaviour
{
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        health = 10;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        transform.GetChild(0).GetComponent<PlayerScript>().manageCollisions(hit);
        if(hit.gameObject.tag == "Bullet")
        {
            health--;
            if(health<=0)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
