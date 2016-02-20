using UnityEngine;
using System.Collections;

public class Orbiter : MonoBehaviour {

	public GameObject toOrbit;
	public int rotation;
	private float distance;

	void Start (){
		distance = Vector3.Distance (gameObject.transform.position, toOrbit.transform.position);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.RotateAround (toOrbit.transform.position, Vector3.up, (rotation/distance) * Time.deltaTime);
	}
}
