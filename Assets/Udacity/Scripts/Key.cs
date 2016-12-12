using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject poof;
    public GameObject door;
    public GameObject key;

    void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this item is located
        // The poof animates vertically
        Instantiate(poof, key.transform.position, Quaternion.identity);

        // Call the Unlock() method on the Door
        // Destroy the key. Check the Unity documentation on how to use Destroy
        // Destroy the key.
        Destroy(key);
    }

}
