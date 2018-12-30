using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
