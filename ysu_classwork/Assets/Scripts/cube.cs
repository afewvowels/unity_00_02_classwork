using UnityEngine;

public class cube : MonoBehaviour
{

	public float speed;
	private float rotation = 0.0f;

	private Rigidbody rbd;

	// Start is called before the first frame update
	void Start()
	{
		rbd = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			rbd.velocity = transform.up * speed;
		}

		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			//rotation += 0.1f;
			//Quaternion rotation = Quaternion.Euler(0, rotation, 0);
		}
	}
}
