using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha : MonoBehaviour {

    public float alphaValue;
    private Color colorA;
    private Material materialA;

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
