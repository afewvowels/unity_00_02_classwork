using UnityEngine;
public class DeleteMe : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Destroy(this.gameObject, Random.Range(8.0f, 14.0f));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
