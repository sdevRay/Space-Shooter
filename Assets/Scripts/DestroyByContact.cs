using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	public GameObject explosion;
	public GameObject playerExplosion;
	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Boundary")
		{
			return;
		}

		Instantiate(explosion, transform.position, transform.rotation); // as GameObject

		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation); // as GameObject
		}

		Destroy(other.gameObject);
		Destroy(gameObject);
	}

}
