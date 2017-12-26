using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public Wave[] waves;

	public Transform start;

	public float waveDelay = 3f;
	public int currentEnemyCount = 0;
	
	
	// Use this for initialization
	void Start () {

		StartCoroutine(SpawnEnemy());
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator SpawnEnemy()
	{
		foreach (Wave wave in waves)
		{
			for (int i = 0; i < wave.totalCount; i++)
			{
				GameObject.Instantiate(wave.enemyPrefab, start.position, Quaternion.identity);
				if (i < waves.Length)
				{
					currentEnemyCount += 1;
					yield return new WaitForSeconds(wave.rate);
				}
				
			}
			while (currentEnemyCount>0)
			{
				yield return 0;
			}
			
			yield return new WaitForSeconds(waveDelay);
		}
	}
}
