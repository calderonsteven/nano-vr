using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
	private bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update()
	private bool opening = false;

	public AudioClip openingSound;
	public AudioClip lockedSound;

    void Update() {
        // If the door is opening and it is not fully raised
            // Animate the door raising up
		if (opening && !locked){
			transform.Rotate(0f, Time.deltaTime * 15f, 0f);
			opening = (transform.localRotation.y < 0.5);
		}


    }

    public void OnDoorClicked() {
		// If the door is clicked and unlocked
		if (!locked && !opening) {
			// Set the "opening" boolean to true
			opening = true;
			this.GetComponent<AudioSource>().clip = openingSound;
			this.GetComponent<AudioSource>().Play();
		} else {
			// (optionally) Else
			// Play a sound to indicate the door is locked
			this.GetComponent<AudioSource>().clip = lockedSound;
			this.GetComponent<AudioSource>().Play();
		}
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
		this.locked = false;
    }
}
