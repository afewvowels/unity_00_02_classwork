using UnityEngine;

public class LookAt : MonoBehaviour
{
	public new GameObject gameObject;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		this.transform.LookAt(gameObject.transform.position);
	}
}
