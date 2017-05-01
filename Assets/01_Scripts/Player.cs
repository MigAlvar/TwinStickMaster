using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (CrossPlatformInputManager.GetButton ("Horizontal")) {
			print ("Horizontal");
		}
		if (CrossPlatformInputManager.GetButton ("Vertical")) {
			print("Vertical");
		}
	}
}
