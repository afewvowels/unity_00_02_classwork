using UnityEngine;

public class shoot : MonoBehaviour
{
	public GameObject projectile;
	public float force;
	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			GameObject proj = (GameObject)Instantiate(projectile, transform.position + (3.0f * transform.forward), transform.rotation);

			proj.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0.0f, 0.0f, force), ForceMode.Impulse);
			proj.GetComponent<Rigidbody>().AddRelativeTorque(new Vector3(Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f), Random.Range(-3.0f, 3.0f)), ForceMode.Impulse);
		}
	}
}
