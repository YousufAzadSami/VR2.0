using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

    public float alphaValue;
    public Color colorA;
    public Material materialA;

	// Use this for initialization
	void Start () {
        materialA = GetComponent<Renderer>().material;
        colorA = materialA.color;
        alphaValue = materialA.color.a;        
    }
	
	// Update is called once per frame
	void Update () {
        colorA.a = alphaValue;
        materialA.color = colorA;
	}
}
