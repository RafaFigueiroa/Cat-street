using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D))]
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
        speed += 1 * Time.deltaTime;
        Debug.Log(speed);

        //Pulo e gravidade
        if (controller.isGrounded) {
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
    }
}
