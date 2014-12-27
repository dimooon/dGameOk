using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public float rotateSpeed = 5.0f;

	void Start () {
	
	}
	
	void Update () {
		transform.RotateAround (Vector3.up, rotateSpeed * Time.deltaTime);
	}
}
