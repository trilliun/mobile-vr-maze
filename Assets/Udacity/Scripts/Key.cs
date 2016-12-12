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
        // Key Animation
        transform.Rotate(0f, 100 * Time.deltaTime, 0f);
    }

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this item is located
        // The poof animates vertically
        Instantiate(poof, key.transform.position, Quaternion.identity);

        // Call the Unlock() method on the Door
        door.GetComponent<Door>().Unlock();

        // Destroy the key.
        Destroy(key);
    }

}
