using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameObject howToPlayPanel;
    public GameObject blurOverlay;
    public CanvasGroup mainMenuGroup;

    public void OpenSettings()
    {
        settingsPanel.SetActive(true);
        blurOverlay.SetActive(true);
        mainMenuGroup.alpha = 0.25f;
    }

    public void CloseSettings()
    {
        settingsPanel.SetActive(false);
        blurOverlay.SetActive(false);
        mainMenuGroup.alpha = 1f;
    }

    public void OpenHowToPlay()
    {
        howToPlayPanel.SetActive(true);
        blurOverlay.SetActive(true);
        mainMenuGroup.alpha = 0.25f;
    }

    public void CloseHowToPlay()
    {
        howToPlayPanel.SetActive(false);
        blurOverlay.SetActive(false);
        mainMenuGroup.alpha = 1f;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}