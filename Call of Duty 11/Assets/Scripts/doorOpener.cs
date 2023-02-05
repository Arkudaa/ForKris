using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOpener : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            GameObject.Find("Door").GetComponent<Animator>().SetTrigger("Doortrigger");
        }
    }



    private void OnTriggerExit(Collider other)
    {
        
    }
}
