using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public Door door;
	bool hasKey = false;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
		transform.Rotate(0, 0, 1);
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy


		Instantiate(keyPoof, transform.position, Quaternion.Euler(-90, 0, 0));
		hasKey = true;

		//unlock the door
		door.Unlock();

		Destroy(gameObject);
    }

}
