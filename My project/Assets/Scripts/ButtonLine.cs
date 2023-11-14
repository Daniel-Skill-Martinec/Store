using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR;

public class SceneSwitcher : MonoBehaviour
{
    public string scene1Name = "Added Heather";
    public string scene2Name = "Added People";
    public string scene3Name = "Base Grocery Store";
    public string buttonName = "Button"; // Replace with the actual button name

    void Update()
    {
        // Check if the specified VR button is pressed
        if (Input.GetButtonDown(buttonName))
        {
            SwitchScene();
        }
    }

    void SwitchScene()
    {
        // Determine the current active scene
        Scene currentScene = SceneManager.GetActiveScene();

        // Switch to the other scene
        if (currentScene.name == scene3Name)
        {
            SceneManager.LoadScene(scene2Name);
        }
    }
}
