using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public GameObject controlsPanel;

    public void StartGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void ToggleControlsPanel()
    {
        if (controlsPanel != null)
        {
            controlsPanel.SetActive(!controlsPanel.activeSelf);
        }
        else
        {
            Debug.LogWarning("ControlsPanel is not assigned in the Inspector!");
        }
    }
}
