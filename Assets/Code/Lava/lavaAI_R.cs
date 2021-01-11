using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaAI_R : MonoBehaviour 

{
	
	public float dirX, moveSpeed = 3f;
	private bool moveRight = true;

	void Update () {
		if (transform.position.x > 54.34f)
			moveRight = false;
		if (transform.position.x < -65.99f)
			moveRight = true;

		if (moveRight)
			transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}
}
