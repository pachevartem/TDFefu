using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{

	public NavMeshAgent _Agent; //none 

	public GameObject SadSmile;
	
	void Start ()
	{
		_Agent.SetDestination(GameController.Instance.Castle.transform.position);
		_Agent.speed = GameController.Instance.SpeedAgent;
		
		
		
	}

	
	
	private void OnEnable()
	{
//		_Agent.SetDestination(GameController.Instance.Castle.transform.position);
	}

	private void Update()
	{
		SadSmile.transform.LookAt(Camera.main.transform);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Bullets")
		{
			kill();
		}
	}

	public void D()
	{
		NavMeshAgent a; 
		
	}

	void kill()
	{
		GameController.Instance.AddScore();
		gameObject.SetActive(false);
	}
}
