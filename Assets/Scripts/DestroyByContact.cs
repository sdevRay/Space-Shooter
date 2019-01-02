using UnityEngine;

public class DestroyByContact : MonoBehaviour
{

	private GameController gameController;
	public GameObject explosion;
	public GameObject playerExplosion;
	public int scoreValue;

	private void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");

		if (gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent<GameController>();
		}

		if(gameController == null)
		{
			Debug.Log("Cannot find 'gameController' script");
		}
	}

	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Boundary")
		{
			return;
		}

		Instantiate(explosion, transform.position, transform.rotation); // as GameObject

		if (other.tag == "Player")
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation); // as GameObject
			gameController.GameOver();
		}

		gameController.AddScore(scoreValue);

		Destroy(other.gameObject);
		Destroy(gameObject);
	}

}
