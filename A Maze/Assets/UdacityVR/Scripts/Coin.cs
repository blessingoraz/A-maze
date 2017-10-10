using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour  
{
	//Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

	public void OnCoinClicked() {
		// Get the position of the coin 
		Instantiate(coinPoof, transform.position, Quaternion.Euler(-90, 0, 0));

		// Destroy this coin. Check the Unity documentation on how to use Destroy
		 Destroy(gameObject);
	}
}
