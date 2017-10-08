using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
	public GameObject door;
	bool locked = true;
	bool opening = false;
	float doorPosition;

	public AudioClip Door_opened;
	public AudioClip Door_locked;

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		//check door y position
		doorPosition = transform.position.y;

		//open door
		if (opening == true && doorPosition < 10)
		{
			door.transform.Translate(new Vector3(-0, 8f * Time.deltaTime, 0));

		}

    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked

		if ( locked == false)
		{
			opening = true;
			AudioSource audio = GetComponent<AudioSource>();
			audio.PlayOneShot(Door_opened);

		}


		else
		{
			AudioSource audio = GetComponent<AudioSource>();
			audio.PlayOneShot(Door_locked);

		}

    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		locked = false;
    }
}
