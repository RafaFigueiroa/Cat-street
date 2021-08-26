using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public CharacterController controller;

    public float speed;
    public float jumpHeight;
    private float jumpVelocity;
    public float gravity;
    public float horizontalSpeed;

    Vector3 forward;
    Vector3 right, left;

    ///private bool isMovingRight, isMovingLeft;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Movement();
    }

    public void Movement() {
        //Movimento Contínuo para frente
        forward = Vector3.forward * speed;


        //Pulo e gravidade
        if (transform.position.y < 0.45f) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                jumpVelocity = jumpHeight;
            }
        }
        else {
            jumpVelocity -= gravity;
        }
        forward.y = jumpVelocity;
        controller.Move(forward * Time.deltaTime);

        //Direita e esquerda
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 10) {
            right = Vector3.right * horizontalSpeed;
            controller.Move(right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -10) {
            left = Vector3.left * horizontalSpeed;
            controller.Move(left * Time.deltaTime);
        }

        //if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 3f && !isMovingRight) {
        //    isMovingRight = true;
        //    StartCoroutine(RightMove());
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -3f && !isMovingLeft) {
        //    isMovingLeft = true;
        //    StartCoroutine(LeftMove());
        //}
    }

    //IEnumerator LeftMove() {
    //    for (float i = 0; i < 10; i += 0.1f) {
    //        controller.Move(Vector3.left * Time.deltaTime * horizontalSpeed);
    //        yield return null;
    //    }

    //    isMovingLeft = false;
    //}

    //IEnumerator RightMove() {
    //    for(float i = 0; i < 10; i += 0.1f) {
    //        controller.Move(Vector3.right * Time.deltaTime * horizontalSpeed);
    //        yield return null;
    //    }

    //    isMovingRight = false;
    //}
}
