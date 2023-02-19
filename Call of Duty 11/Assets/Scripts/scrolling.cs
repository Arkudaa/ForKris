using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrolling : MonoBehaviour
{
    public float scrollX;
    public float scrollY;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        float OffsetX = Time.time * scrollX;
        float OffsetY = Time.time * scrollY;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(OffsetX,OffsetY);
    }
}
