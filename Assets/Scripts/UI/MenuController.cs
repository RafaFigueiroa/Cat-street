using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public Animator soundAnim;
    public Animator exitAnim;
    public int optionsOut = 0;

    void Start() {
    }

    public void AnimOptions() {
        if (optionsOut == 0) {
            soundAnim.Play("Up1");
            exitAnim.Play("Up2");

            optionsOut = 1;
        }
        else if (optionsOut == 1) {
            soundAnim.Play("Down1");
            exitAnim.Play("Down2");

            optionsOut = 2;
        }
        else if (optionsOut == 2) {
            soundAnim.Play("Up1");
            exitAnim.Play("Up2");

            optionsOut = 1;
        }
    }

    public void StartFase1Scene() {
        SceneManager.LoadScene("Fase1Scene");
    }

    public void StartMenuScene() {
        SceneManager.LoadScene("MenuScene");
    }

    public void QuitGame() {
        Application.Quit();
    }
}
