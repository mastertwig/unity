using UnityEngine;
using System.Collections;

public class ShotBehavior : MonoBehaviour {

    public float speed;
	
	// Update is called once per frame
	void Update () {
		transform.position += transform.forward * Time.deltaTime * speed;
	
	}
}
