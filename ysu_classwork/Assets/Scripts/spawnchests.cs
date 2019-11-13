using UnityEngine;

public class spawnchests : MonoBehaviour
{

	public GameObject spawnObject;
	public int interval;

	private int counter;

	// Start is called before the first frame update
	void Start()
	{
		counter = 0;
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		counter++;
		if (counter % interval == 0)
		{
			Instantiate(spawnObject, transform.position, Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f)));
		}
	}
}
