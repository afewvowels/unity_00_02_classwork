using UnityEngine;

public class Spin : MonoBehaviour
{
	private float rotY;

	public float speed;
	// Start is called before the first frame update
	void Start()
	{
		rotY = 0.0f;
	}

	// Update is called once per frame
	void Update()
	{
		if (rotY < 360.0f)
		{
			rotY += speed;
		}
		else if (rotY >= 360.0f)
		{
			rotY = 0.0f;
		}

		this.transform.localRotation = Quaternion.Euler(this.transform.localRotation.eulerAngles.x, rotY, this.transform.localRotation.eulerAngles.z);
	}
}
