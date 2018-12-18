using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCheck : MonoBehaviour {

	//Makes the Sprites that need to be invisible well invisible//
	void Start () {
        GetComponent<SpriteRenderer>().enabled = false;

	}

}
