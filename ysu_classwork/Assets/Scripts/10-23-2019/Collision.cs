using UnityEngine;

public class Collision : MonoBehaviour
{
	private int iterationCount;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnCollisionEnter(UnityEngine.Collision collision)
	{
		GameObject go = collision.gameObject;

		if (go.CompareTag("chest"))
		{
			Destroy(this.gameObject);
		}
	}

	private void OnTriggerEnter(Collider other)
	{

	}
}
