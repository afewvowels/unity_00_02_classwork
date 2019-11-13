using UnityEngine;

public class MoveToObject : MonoBehaviour
{
	public float speed;

	public GameObject target;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		float deltaX = target.transform.position.x - this.transform.position.x;
		float deltaY = target.transform.position.y - this.transform.position.y;
		float deltaZ = target.transform.position.y - this.transform.position.z;

		Vector3 delta = new Vector3(deltaX, deltaY, deltaZ);

		Vector3 movement = Vector3.ClampMagnitude(delta, speed);

		// Much easier, can just subtract the vectors instead of breaking them down into their parts
		// Vector3 delta = target.transform.position - this.transform.position

		transform.position += movement;

	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "target")
		{
			this.transform.position = new Vector3(0, 0, 0);
		}
	}
}
