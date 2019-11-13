using UnityEngine;

public class move : MonoBehaviour
{
	Rigidbody rb;
	public float force;
	public float torque;
	// Start is called before the first frame update
	void Start()
	{
		rb = this.GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rb.AddRelativeForce(new Vector3(0.0f, 0.0f, force));
		}

		if (Input.GetKey(KeyCode.RightArrow))
		{
			rb.AddRelativeTorque(new Vector3(0.0f, torque, 0.0f));
		}

		if (Input.GetKey(KeyCode.LeftArrow))
		{
			rb.AddRelativeTorque(new Vector3(0.0f, -torque, 0.0f));
		}
	}
}
