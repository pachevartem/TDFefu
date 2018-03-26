using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
	
	public GameObject Castle;


	[Header("Введите сюда скорость Агентов")]
	public float SpeedAgent;

	public static GameController Instance;

	public Text  TextKill;
	private int killEnemy;

	public int KillEnemy
	{
		get { return killEnemy; }
		set
		{
			killEnemy = value;
			TextKill.text = killEnemy.ToString();
		}
	}


	public void AddScore()
	{
		KillEnemy++;
	}

	void SingleTon()
	{
		if (Instance == null && Instance != this)
		{
			Instance = this;
		}
		else
		{
			Destroy(gameObject);
		}
		
		DontDestroyOnLoad(gameObject);
	}


	private void Awake()
	{
		SingleTon();
	}
}
