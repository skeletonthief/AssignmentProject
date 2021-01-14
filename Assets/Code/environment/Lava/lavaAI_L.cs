using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lavaAI_L : MonoBehaviour 

{
	public int lava_AI_L;
	public float dirX, moveSpeed = 3f;
	private bool moveRight = true;

	void Update () {
		if (transform.position.x > 81.37f)
			moveRight = false;
		if (transform.position.x < -82.08)
			moveRight = true;
		
		if (moveRight)
			transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
		else
			transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}
}
