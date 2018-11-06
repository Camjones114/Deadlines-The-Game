using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class athlete : player {

	public athlete(){
		health = 4;
		damage = 3;
	}

	public void Start(){
		movement.setMovementspeed(8f);
		movement.setJumpheight (14f);
	}

	public void attack(){
		
	}

}
