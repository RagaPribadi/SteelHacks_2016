using UnityEngine;
using System.Collections;

public class Orbiter : MonoBehaviour {

	public GameObject toOrbit;
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.RotateAround (toOrbit.transform.position, Vector3.up, 20 * Time.deltaTime);
	}
}
