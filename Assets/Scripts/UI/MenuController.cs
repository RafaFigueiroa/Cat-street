using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void StartMenuScene() {
        SceneManager.LoadScene("MenuScene");
    }
    
    public void StartChooseFaseScene() {
        SceneManager.LoadScene("ChooseFaseScene");
    }

    public void StartCreditsScene() {
        SceneManager.LoadScene("CreditsScene");
    }

    public void StartFase1Scene() {
        SceneManager.LoadScene("Fase1Scene");
    }
}
