﻿using UnityEngine;

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

		if (gameController == null)
		{
			Debug.Log("Cannot find 'gameController' script");
		}
	}

	// Use this for initialization
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Boundary") || other.CompareTag("Enemy"))
		{
			return;
		}

		if (explosion != null)
		{
			Instantiate(explosion, transform.position, transform.rotation);
		}

		if (other.CompareTag("Player"))
		{
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver();
		}

		gameController.AddScore(scoreValue);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}

}
