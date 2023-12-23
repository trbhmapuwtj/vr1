using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cube : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public GameObject capsule;

    void Start()
    {
        
    }

    void FixedUpdate()
    {
       
    }

    public void ChangeColor()
    {
        a = Random.Range(0, 255);
        b = Random.Range(0, 255);
        c = Random.Range(0, 255);
        this.gameObject.GetComponent<Renderer>().material.color = new Color32((byte) a, (byte) b, (byte) c, 1);
        capsule.gameObject.GetComponent<Renderer>().material.color = new Color32((byte)(255 - a), (byte)(255 - b), (byte)(255 - c), 1);
    }
}
