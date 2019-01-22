using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float MovSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(Input.GetAxis("Horizontal") * MovSpeed * Time.deltaTime, 0, Input.GetAxis("Vertical") * MovSpeed * Time.deltaTime);
	}
}
