using UnityEngine;

public class Teleport : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		float x = this.transform.position.x;
		float y = this.transform.position.y;
		float z = this.transform.position.z;

		Debug.Log("Position: (" + x + "," + y + "," + z + ")");
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			this.transform.position = new Vector3(1.0f, 2.0f, 3.0f);
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			this.transform.position = new Vector3(2.0f, 1.0f, 3.0f);
		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			this.transform.position = new Vector3(3.0f, 1.0f, 2.0f);
		}
		else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			this.transform.position = new Vector3(0.0f, 1.0f, 0.0f);
		}
	}
}
