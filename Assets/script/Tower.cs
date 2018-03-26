using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
	
	[Header("Перетяни сюда модель орудия")]
	public Transform Gun;
	
	[Header("Перетяни место поражения")]
	public Transform Target;
	
	[Header("Перетяни сюда модель Снаряда")]
	public Transform Bolt;
	
	[Header("Укажи место появления пули")]
	public Transform BoltSpawn;

	[Header("Укажи скорость снаряда")]
	public float Speed;
	
	
	
	private void Start()
	{
		SetUpPositionBolt();
	}

	private void SetUpPositionBolt()
	{
		Bolt.position = BoltSpawn.position;
	}
	
	
	void Update () {
		
		Quaternion _dir = Quaternion.LookRotation(Target.position-Gun.transform.position);
		Gun.rotation = new Quaternion(Gun.rotation.x,_dir.y,Gun.rotation.z,_dir.w);
		
		
		Bolt.position = Vector3.MoveTowards(Bolt.position, Target.position, Time.deltaTime*Speed);

		if (Bolt.position == Target.position)
		{
			SetUpPositionBolt();
		}
	}
}
