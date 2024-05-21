using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damege : MonoBehaviour
{

    // Start is called before the first frame update
    public byte defens;
   
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();

        Color currentColor = renderer.material.color;
        UnityEngine.Debug.Log("r=" + currentColor. r);
        UnityEngine.Debug.Log("g=" + currentColor.g);
        UnityEngine.Debug.Log("b=" + currentColor.b);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void DamegeColor(byte r, byte g, byte b) {
        byte[] tmpColor = new byte[3];
        tmpColor= DamegeCul(r, g, b, defens);
        UnityEngine.Debug.Log("r=" + tmpColor[0]);
  //      UnityEngine.Debug.Log("g=" + tmpColor[1]);
     //   UnityEngine.Debug.Log("b=" + tmpColor[2]);
        GetComponent<Renderer>().material.color = new Color32(tmpColor[0], tmpColor[1], tmpColor[2], 255);
        if(tmpColor[0] == 0 && tmpColor[1] ==0 && tmpColor[2] == 0)
        {
            Destroy(gameObject);
        }
    }
    private byte[] DamegeCul(byte r, byte g, byte b, byte biock)
    {
        Renderer renderer = GetComponent<Renderer>();

        Color currentColor = renderer.material.color;
     
        byte[] result = new byte[3];
        byte tmpr = (byte)(currentColor.r * 255f);
        byte tmpg = (byte)(currentColor.g * 255f);
        byte tmpb = (byte)(currentColor.b * 255f); 
        UnityEngine.Debug.Log("tmpr=" + tmpr);
        if (tmpr != 0)
        {   if (tmpr - ((255 - r) / biock) < 0) tmpr = 0;
            else tmpr = (byte)(tmpr - ((255 - r) / biock));
        }
        UnityEngine.Debug.Log("tmpr=" + tmpr);

        if (tmpb != 0)
        {
            if (tmpb - ((255 - b) / biock) < 0) tmpb = 0;
            else tmpb = (byte)(tmpb - ((255 - b) / biock));
        }

        if (tmpg != 0)
        {
            if (tmpg - ((255 - g) / biock) < 0) tmpg = 0;
            else tmpg = (byte)(tmpg - ((255 - g) / biock));
        }


        result[0] = tmpr;
        result[1] = tmpg;
        result[2] = tmpb;
        return result;
    } 
}
