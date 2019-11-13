using UnityEngine;

public class MoveGlobal : MonoBehaviour
{
	public float speed;
	public new GameObject target;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Vector3 delta = new Vector3();
		delta = this.transform.position;
		if (Input.GetKey("w"))
		{
			delta.z = this.transform.position.z + speed;
		}
		if (Input.GetKey("s"))
		{
			delta.z = this.transform.position.z - speed;
		}
		if (Input.GetKey("a"))
		{
			delta.x = this.transform.position.x - speed;
		}
		if (Input.GetKey("d"))
		{
			delta.x = this.transform.position.x + speed;
		}

		//this.transform.position = delta;
		this.transform.Translate(delta, Space.World);
	}
}
