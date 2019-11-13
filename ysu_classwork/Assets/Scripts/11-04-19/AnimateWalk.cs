using UnityEngine;

public class AnimateWalk : MonoBehaviour
{
	private Animator animator;

	private float timer;

	// Start is called before the first frame update
	void Start()
	{
		animator = this.GetComponent<Animator>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.Q))
		{
			animator.SetBool("wave", true);
			timer = 0.0f;
		}
		if (Input.GetKey(KeyCode.W))
		{
			animator.SetBool("walk", true);
		}
		if (!Input.GetKey(KeyCode.W))
		{
			animator.SetBool("walk", false);
		}

		timer += Time.deltaTime;

		if (timer >= 1.0f)
		{
			animator.SetBool("wave", false);
		}
	}
}
