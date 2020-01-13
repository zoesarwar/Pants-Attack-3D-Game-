using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public static float jeansLeft = 5;
    public static float countdown = 25;
    public static float level = 1;

    public Text jeansLeftText;
    public Text countdownText;
    public Text levelText;

    CharacterController controller;

    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    public float rotateSpeed = 3.0f;
    public float rotate = 0.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        jeansLeftText.text = jeansLeft.ToString();
        countdownText.text = "" + Mathf.Round(countdown);
        levelText.text = level.ToString();
        countdown -= Time.deltaTime;

        if (countdown <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        if (jeansLeft <= 0)
        {
            ButtonController.increase += 2f;
            SceneManager.LoadScene("NextLevel");
        }

        moveDirection = new Vector3(0, 0.0f, Input.GetAxis("Vertical"));
        moveDirection *= speed;
        moveDirection = transform.TransformDirection(moveDirection);

        rotate += Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rotate, 0);

        moveDirection.y -= gravity * Time.deltaTime;

        controller.Move(moveDirection * Time.deltaTime);

    }
}
