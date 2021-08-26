using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject playButton;
    public GameObject menuButton;
    public GameObject configButton;
    public GameObject restImage;

    public void PauseGame() {
        Time.timeScale = 0;

        pauseButton.SetActive(false);
        playButton.SetActive(true);
        menuButton.SetActive(true);
        configButton.SetActive(true);
        restImage.SetActive(true);
    }

    public void UnpauseGame() {
        Time.timeScale = 1;

        pauseButton.SetActive(true);
        playButton.SetActive(false);
        menuButton.SetActive(false);
        configButton.SetActive(false);
        restImage.SetActive(false);
    }
    public void OpenUIPause() {

    }
}
