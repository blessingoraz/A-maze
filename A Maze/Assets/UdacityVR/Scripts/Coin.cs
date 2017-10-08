using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;
	public GameObject coin;

	float xPosition;
	float zPosition;

    public void OnCoinClicked() {
       
		xPosition = coin.transform.position.x;
		zPosition = coin.transform.position.z;

		//instantiate the coinPoof prefab 
		Object.Instantiate(coinPoof, new Vector3(xPosition, 0, zPosition), Quaternion.Euler(-90, 0, 0));

		// Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(coin);

		//print checks
		print("Coin got here");
    }

}
