using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
	public Wave[] waves;

	public Transform start;

	public float waveDelay = 3f;
	
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
					yield return new WaitForSeconds(wave.rate);
				}
				
			}
			
			yield return new WaitForSeconds(waveDelay);
		}
	}
}
