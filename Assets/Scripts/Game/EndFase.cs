using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFase : MonoBehaviour
{
    public Transform pontoFinal;
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = player.position.z - pontoFinal.position.z;

        if (player.position.z >= pontoFinal.position.z) {
            SceneManager.LoadScene("MenuScene");
        }
    }
}
