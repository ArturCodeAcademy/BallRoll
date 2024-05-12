using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _player;

	private void LateUpdate()
	{
		transform.position = new Vector3(transform.position.x, _player.position.y, _player.position.z);
	}
}
