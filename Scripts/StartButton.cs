//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class S : MonoBehaviour
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
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    public Button startButton; // Reference to the Start Button

    private void Start()
    {
        // Ensure the button is not null
        if (startButton != null)
        {
            // Add a listener to the button
            startButton.onClick.AddListener(OnStartButtonClicked);
        }
        else
        {
            Debug.LogError("Start Button is not assigned in the Inspector");
        }
    }

    private void OnStartButtonClicked()
    {
        // Handle button click event
        Debug.Log("Start Button Clicked");

        // Example: Load the next scene or perform any other action
        SceneManager.LoadScene("LevelScreen"); // Replace "LevelSelection" with the name of the scene you want to load
    }
}
