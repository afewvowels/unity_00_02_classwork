using UnityEngine;

public class Fly : MonoBehaviour
{
	public float positionY;
	// Start is called before the first frame update
	void Start()
	{
		positionY = this.transform.position.y;
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			positionY = 1.0f;
		}

		positionY += 0.01f;
		this.transform.position = new Vector3(this.transform.position.x, positionY, this.transform.position.z);

	}
}
