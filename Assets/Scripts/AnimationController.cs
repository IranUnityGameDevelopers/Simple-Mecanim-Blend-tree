using UnityEngine;
using System.Collections;

public class AnimationController : MonoBehaviour 
{
	private Animator animator;



	void Start () 
	{
		animator = GetComponent<Animator>();
	}
	

	void Update () 
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		animator.SetFloat("DirectionUPDown",v);
		animator.SetFloat("DirectionLeftRight",h);
	}
}
