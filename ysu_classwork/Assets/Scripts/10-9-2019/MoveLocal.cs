using UnityEngine;

public class MoveLocal : MonoBehaviour
{
	public float speedForwards;
	public float speedRotation;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.Translate(new Vector3(0.0f, 0.0f, speedForwards));
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.Rotate(new Vector3(0.0f, speedRotation, 0.0f));
		}
		else if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.Rotate(new Vector3(0.0f, -speedRotation, 0.0f));
		}
	}
}
