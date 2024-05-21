using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class attck : MonoBehaviour
{
    public byte r;
    public byte g;
    public byte b;
    void OnCollisionEnter2D(Collision2D collision)
    {
      //  UnityEngine.Debug.Log("eleer");
        Damege dam = collision.gameObject.GetComponent<Damege>();

        if(dam != null)
        {
      //      UnityEngine.Debug.Log("2");
            dam.DamegeColor(r, g, b);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
       GetComponent<Renderer>().material.color = new Color32(r, g, b,255);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
