using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuilManager : MonoBehaviour
{

	public TurretData LaserTurretData;
	public TurretData MissileTurretData;
	public TurretData StanderTurretData;
	// Use this for initialization
	
	//将要创建的
	public TurretData selectedTurretData;

	public void OnLaserSelected(bool isOne){
		if (isOne)
		{
			selectedTurretData = LaserTurretData;
			
		}
	}
	public void OnMissileSelected(bool isOne){
		if (isOne)
		{
			selectedTurretData = MissileTurretData;
			
		}
	}
	public void OnStanderSelected(bool isOne)
	{
		if (isOne)
		{
			selectedTurretData = StanderTurretData;
			
		}
	}
}
