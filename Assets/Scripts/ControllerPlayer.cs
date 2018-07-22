using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : Controller {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.D))
        {
            pawn.Move(1);
        }

        if (Input.GetKey(KeyCode.A))
        {
            pawn.Move(-1);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            pawn.Jump();
        }

	}
}
