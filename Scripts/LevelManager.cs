//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class LevelManager : MonoBehaviour
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


//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//public class LevelManager : MonoBehaviour
//{
//    public Button[] levelButtons; // Array to hold references to the level buttons
//    public Sprite lockSprite; // Reference to the lock sprite
//    public Sprite unlockedSprite; // Reference to the unlocked level sprite or default sprite

//    void Start()
//    {
//        // Load the level progression data
//        int levelReached = PlayerPrefs.GetInt("LevelReached", 1); // Defaults to 1 if not found

//        // Loop through all the level buttons
//        for (int i = 0; i < levelButtons.Length; i++)
//        {
//            if (i + 1 > levelReached) // If the level index is greater than the level reached
//            {
//                // Level is locked
//                levelButtons[i].image.sprite = lockSprite; // Display the lock sprite
//                levelButtons[i].interactable = false; // Disable the button
//            }
//            else
//            {
//                // Level is unlocked
//                levelButtons[i].image.sprite = unlockedSprite; // Display the unlocked sprite or leave as default
//                levelButtons[i].interactable = true; // Enable the button
//                int levelIndex = i + 1;
//                levelButtons[i].onClick.AddListener(() => LoadLevel(levelIndex)); // Add listener to load the level
//            }
//        }
//    }

//    // Function to load the selected level
//    void LoadLevel(int levelIndex)
//    {
//        SceneManager.LoadScene("Level" + levelIndex); // Ensure your levels are named like "Level1", "Level2", etc.
//    }

//    // Function to call when a level is completed, to unlock the next level
//    public void LevelCompleted(int levelIndex)
//    {
//        if (levelIndex >= PlayerPrefs.GetInt("LevelReached", 1))
//        {
//            PlayerPrefs.SetInt("LevelReached", levelIndex + 1);
//        }
//    }
//}


//using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;

//public class LevelManager : MonoBehaviour
//{
//    public Button[] levelButtons; // Array to hold references to the level buttons
//    public Sprite lockSprite; // Reference to the lock sprite
//    public Sprite unlockedSprite; // Reference to the unlocked level sprite or default sprite

//    void Start()
//    {
//        // Load the level progression data
//        int levelReached = PlayerPrefs.GetInt("LevelReached", 1); // Defaults to 1 if not found

//        // Loop through all the level buttons
//        for (int i = 0; i < levelButtons.Length; i++)
//        {
//            if (i + 1 > levelReached) // If the level index is greater than the level reached
//            {
//                // Level is locked
//                levelButtons[i].image.sprite = lockSprite; // Display the lock sprite
//                levelButtons[i].interactable = false; // Disable the button
//            }
//            else
//            {
//                // Level is unlocked
//                levelButtons[i].image.sprite = unlockedSprite; // Display the unlocked sprite or leave as default
//                levelButtons[i].interactable = true; // Enable the button
//                int levelIndex = i + 1;
//                levelButtons[i].onClick.RemoveAllListeners(); // Clear any previous listeners
//                levelButtons[i].onClick.AddListener(() => LoadLevel(levelIndex)); // Add listener to load the level
//            }
//        }
//    }

//    // Function to load the selected level
//    void LoadLevel(int levelIndex)
//    {
//        SceneManager.LoadScene("Level" + levelIndex); // Ensure your levels are named like "Level1", "Level2", etc.
//    }

//    // Function to call when a level is completed, to unlock the next level
//    public void LevelCompleted(int levelIndex)
//    {
//        if (levelIndex >= PlayerPrefs.GetInt("LevelReached", 1))
//        {
//            PlayerPrefs.SetInt("LevelReached", levelIndex + 1);
//        }
//    }
//}



using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public Button[] levelButtons; // Array to hold references to the level buttons
    public Sprite lockSprite; // Reference to the lock sprite
    public Sprite unlockedSprite; // Reference to the unlocked level sprite or default sprite

    void Start()
    {
        // Load the level progression data
        int levelReached = PlayerPrefs.GetInt("LevelReached", 1); // Defaults to 1 if not found

        // Loop through all the level buttons
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached) // If the level index is greater than the level reached
            {
                // Level is locked
                levelButtons[i].image.sprite = lockSprite; // Display the lock sprite
                levelButtons[i].interactable = false; // Disable the button
            }
            else
            {
                // Level is unlocked
                levelButtons[i].image.sprite = unlockedSprite; // Display the unlocked sprite or leave as default
                levelButtons[i].interactable = true; // Enable the button
                int levelIndex = i + 1;
                levelButtons[i].onClick.RemoveAllListeners(); // Clear any previous listeners
                levelButtons[i].onClick.AddListener(() => LoadLevel(levelIndex)); // Add listener to load the level
            }
        }
    }

    // Function to load the selected level
    void LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene("Level" + levelIndex); // Ensure your levels are named like "Level1", "Level2", etc.
    }

    // Function to call when a level is completed, to unlock the next level
    public void LevelCompleted(int levelIndex)
    {
        if (levelIndex >= PlayerPrefs.GetInt("LevelReached", 1))
        {
            PlayerPrefs.SetInt("LevelReached", levelIndex + 1);
        }
        SceneManager.LoadScene("Levels");
    }
}
