using UnityEngine;

public class HelloWorld : MonoBehaviour
{
	private int counter = 0;

	// Start is called before the first frame update
	void Start()
	{
		Debug.Log("hello world");
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		counter++;
		Debug.Log(counter);
	}
}
