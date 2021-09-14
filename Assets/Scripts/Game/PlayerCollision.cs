using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    private int lifes = 3;
    public Image countLifes;

    public Sprite tresvidas, duasvidas, umavida;

    public GameObject GameScene, GameOverScene, lifesImage;

    void Start()
    {
    }

    void Update()
    {
        if (lifes == 3) {
            countLifes.sprite = tresvidas;
        }
        else if (lifes == 2) {
            countLifes.sprite = duasvidas;
        }
        else if (lifes == 1) {
            countLifes.sprite = umavida;
        }

        if (lifes == 0) {
            GameScene.SetActive(false);
            GameOverScene.SetActive(true);


            lifesImage.SetActive(false);
        }
    }

    public void OnTriggerExit(Collider collision) {
        if (collision.tag == "Obstacle") {
            lifes -= 1;
        }
    }
}
