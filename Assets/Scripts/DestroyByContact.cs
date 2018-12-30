using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Boundary")
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(gameObject);
	}

}
