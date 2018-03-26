using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{


	public Transform posA;
	public Transform posB;

	[Header("Укажи скорость снаряда")]
	public float Speed;

	private void Start()
	{
		SetUpPositionBolt();
	}


	private void SetUpPositionBolt()
	{
		this.transform.position = posA.position;
	}

	void Update()
	{
		this.transform.position = Vector3.MoveTowards(this.transform.position, posB.position, Time.deltaTime*Speed);

		if (transform.position == posB.position)
		{
			SetUpPositionBolt();
		}
	}
}
