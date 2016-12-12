using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ResetScene : MonoBehaviour {
    public void RestartScene(string sceneName)
    {
        Debug.Log("My method was called.");
        SceneManager.LoadScene(sceneName);
    }
}
