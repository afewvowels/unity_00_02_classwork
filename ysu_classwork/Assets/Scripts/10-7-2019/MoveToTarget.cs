using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
	// Position
	private float posX;
	private float posY;
	private float posZ;

	private float dx;
	private float dy;
	private float dz;

	// Where I want to move to
	public float newPosX;
	public float newPosY;
	public float newPosZ;

	public float speed;

	private float distance;
	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		// Target - current
		// Or reverse for movement away (or use negative speed)
		dx = newPosX - transform.position.x;
		dy = newPosY - transform.position.y;
		dz = newPosZ - transform.position.z;

		Vector3 delta = new Vector3(dx, dy, dz);

		Vector3 movement = Vector3.ClampMagnitude(delta, speed);

		transform.position += movement;
	}
}
