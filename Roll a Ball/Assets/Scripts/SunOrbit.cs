using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunOrbit : MonoBehaviour {

	public float orbitTime; // time (sec) to "orbit" the sun (in this case, sun orbits us)

	private float y;
	private float t;
	
	// Update is called once per frame
	void Update () 
	{
		y = (360.0f / orbitTime) * Time.deltaTime;
		transform.Rotate (0, y, 0);
	}
}
