using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public GameObject key;
	public Door door;

	float xPosition;
	float zPosition;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        // Call the Unlock() method on the Door
        // Set the Key Collected Variable to true
        // Destroy the key. Check the Unity documentation on how to use Destroy

		xPosition = key.transform.position.x;
		zPosition = key.transform.position.z;

		Object.Instantiate(keyPoof, new Vector3(xPosition, 0, zPosition), Quaternion.Euler(-90, 0, 0));

		//unlock the door
		door.Unlock();

		Destroy(key);
    }

}
