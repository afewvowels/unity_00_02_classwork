using UnityEngine;

public class Chase : MonoBehaviour
{
	public float speed;
	public new GameObject target;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		Vector3 delta = new Vector3();
		//if (Input.GetKey(KeyCode.UpArrow))
		//{
		//	delta = target.transform.position - this.transform.position;
		//}
		//else
		//{
		//	delta = this.transform.position - target.transform.position;
		//}
		delta = target.transform.position - this.transform.position;
		Vector3 movement = Vector3.ClampMagnitude(delta, speed);
		this.transform.position += movement;
	}
}
