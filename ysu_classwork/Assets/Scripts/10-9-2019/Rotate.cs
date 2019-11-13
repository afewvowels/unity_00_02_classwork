using UnityEngine;

public class Rotate : MonoBehaviour
{
	public float speed;

	private float rotZ;
	// Start is called before the first frame update
	void Start()
	{
		rotZ = 0.0f;
	}

	// Update is called once per frame
	void Update()
	{
		if (rotZ < 360)
		{
			rotZ += speed;
		}
		else if (rotZ >= 360)
		{
			rotZ = 0.0f;
		}
		this.transform.localRotation = Quaternion.Euler(0.0f, 0.0f, rotZ);
	}
}
