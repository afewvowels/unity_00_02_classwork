using UnityEngine;

public class Forces : MonoBehaviour
{
	private Rigidbody rb;
	// Start is called before the first frame update
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			rb.AddRelativeForce(new Vector3(0.0f, 9.8f, 0.0f));
			rb.AddTorque(new Vector3(2.0f, 5.0f, -2.0f));
		}
	}
}
