using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in Update() 
    bool locked = true;

    void Update() {
        // If the door is unlocked and it is not fully raised
        if (locked == false && transform.position.y < 25.3)
        {
            // Animate the door raising up
            transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World);
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to true here
        locked = false;
    }
}
