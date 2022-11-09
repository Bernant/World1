using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raindow : MonoBehaviour
{
    public int a;
    public int b;
    public int c;
    public GameObject Hero;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void raincolor()
    {
        a = Random.Range(0, 255);
        b = Random.Range(0, 255);
        c = Random.Range(0, 255);
        Hero.GetComponent<Renderer>().material.color = new Color32((byte)a, (byte)b, (byte)c, 255);
    }
}
