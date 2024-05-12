using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
	[SerializeField] private Hill[] _roadPrefabs;
	[SerializeField] private Transform _player;

	private Vector3 _lastRoadEnd = Vector3.zero;

	private IEnumerator Start()
	{
		WaitForSeconds wait = new (1);

		while (true)
		{
			//if (_player.position.z > _lastRoadEnd.z - 50)
				_lastRoadEnd = GenerateRoad(_lastRoadEnd);

			yield return wait;
		}
	}

	private Vector3 GenerateRoad(Vector3 lastRoadEnd)
	{
		Hill prefab = _roadPrefabs[Random.Range(0, _roadPrefabs.Length)];
		Hill road = Instantiate(prefab, lastRoadEnd, prefab.transform.rotation, transform);
		return road.End.position;
	}
}
