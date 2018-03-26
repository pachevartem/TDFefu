using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTest : MonoBehaviour {
	
	private void OnCollisionEnter(Collision other)
	{
//		GetComponent<Rigidbody>().AddForce(Vector3.up *2, ForceMode.Impulse);
//		print("Enter");
	}

	private void OnCollisionStay(Collision other)
	{
//		print("Stay");

	}

	private void OnTriggerEnter(Collider other)
	{
		print("Enter");
	}

	private void OnTriggerStay(Collider other)
	{
		print("Stay");
	}

	private void OnTriggerExit(Collider other)
	{
		print("Exit");
	}
}
