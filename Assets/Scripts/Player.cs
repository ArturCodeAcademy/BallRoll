using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField, Min(0)] private float _force = 5f;
    [SerializeField, Min(0)] private float _jumpImpulse = 5f;

    private Rigidbody _rigidbody;

    private void Awake()
    {
		_rigidbody = GetComponent<Rigidbody>();
	}

    private void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space))
        {
			_rigidbody.AddForce(Vector3.up * _jumpImpulse, ForceMode.Impulse);
		}
	}

	private void FixedUpdate()
	{
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 force = new Vector3(horizontal, 0, vertical) * _force;
		_rigidbody.AddForce(force);
	}
}
