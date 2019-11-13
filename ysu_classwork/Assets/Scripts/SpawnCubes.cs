using UnityEngine;

public class SpawnCubes : MonoBehaviour
{
	public GameObject prefab;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Instantiate(prefab).transform.position = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
	}
}
