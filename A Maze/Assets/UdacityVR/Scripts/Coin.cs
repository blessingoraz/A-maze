using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour  
{
	//Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

	public void OnCoinClicked() {
		// I rotated the coin so I had to rotate the coinPoof as well
		Instantiate(coinPoof, this.transform.position, Quaternion.Euler(-90, 0, 0));

		// Destroy this coin. Check the Unity documentation on how to use Destroy
		  
			print ("getting here");
			// Do something  
			Destroy(this.gameObject);
	}
}
