using UnityEngine;

public class ResetPosition : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnTriggerEnter(Collider other)
	{
		this.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
	}
}
