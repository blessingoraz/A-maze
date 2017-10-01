using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin : MonoBehaviour {

	public GameObject rotateCoin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rotateCoin.transform.Rotate (0f, Time.deltaTime, 0f);
	}
}
