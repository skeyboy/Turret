using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class TurretData
{

	public GameObject turretPrefab;
	public GameObject turretUpgradedPrefab;
	public int cost = 50;
	public int costUpgraded =100;
	public TurretType type;
}

public enum TurretType
{
	LaserTurret,
	MissileTurret,
	StanderTurret,
}