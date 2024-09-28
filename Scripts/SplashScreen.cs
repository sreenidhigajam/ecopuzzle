//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SplashScreen : MonoBehaviour
//{
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }
//}

using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreenManager : MonoBehaviour
{
    public float delay = 3f; // Delay in seconds before transitioning to the next scene

    private void Start()
    {
        // Call the LoadNextScene method after the specified delay
        Invoke("LoadNextScene", delay);
    }

    private void LoadNextScene()
    {
        // Load the Start Button screen scene
        SceneManager.LoadScene("StartButtonScreen"); // Replace with your start button screen scene name
    }
}

