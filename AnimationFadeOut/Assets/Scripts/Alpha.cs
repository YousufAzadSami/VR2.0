using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alpha : MonoBehaviour {

    //public float alphaValue = 1;
    //private Color colorA;
    private Material materialA;

    public Color colorValue;
    //public Color oldColor;

	// Use this for initialization
	void Start () {
        materialA = GetComponent<Renderer>().material;
        //colorA = materialA.color;
        //alphaValue = materialA.color.a;

        colorValue = materialA.color;
    }
	
	// Update is called once per frame
	void Update () {
        //colorA.a = alphaValue;
        //materialA.color = colorA;

        materialA.color = colorValue;
	}
}
