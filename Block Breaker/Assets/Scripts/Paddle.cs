using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    float mousePosInBlocks;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePos = new Vector3 (-6f, this.transform.position.y, 0f);

		mousePosInBlocks = (Input.mousePosition.x / Screen.width) * 16 - 8;

        paddlePos.x = Mathf.Clamp(mousePosInBlocks, -7f, 7f);

        this.transform.position = paddlePos;
	}
}
