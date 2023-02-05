using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject bullet;
    public GameObject target;
    public Transform targetPosition;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);
        time += Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, 0.05f);
        if (time >= 2)
        {
            time = 0;
            GameObject t = Instantiate(bullet, transform.position, Quaternion.identity);
            Destroy(t, 3);
            t.GetComponent<Rigidbody>().AddForce(transform.forward * 5000);
            
        }

        

    }
}
