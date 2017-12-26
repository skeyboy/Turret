using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	private Transform[] positions;

	private int index = 0;
	public float steep = 10;

	public EnemySpawner	 Spawner;


	private void Awake()
	{
		//找到WaveManager 然后再找到EnemySpawner
		Spawner = GameObject.FindGameObjectWithTag("WaveManager").GetComponent<EnemySpawner>();
		
	}

	// Use this for initialization
	void Start () {
		positions = WayPointManager.positions;
		
	}
	
	// Update is called once per frame
	void Update () {
	}

	private void FixedUpdate()
	{
		Move();
	}

	private void Move()
	{
		if (index >= positions.Length)
		{
			Destroy(GameObject.FindGameObjectWithTag("Enemy"));
			return;
		}
		transform.Translate( (positions[index].position-transform.position).normalized *Time.deltaTime*steep);
		if (Vector3.Distance(positions[index].position, transform.position) <= 0.2)
		{
			index++;			
		}
	}

	private void OnDestroy()
	{
		Spawner.currentEnemyCount--;
	}
}
