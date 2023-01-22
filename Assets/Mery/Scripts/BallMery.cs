using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallMery : MonoBehaviour
{
    private Rigidbody rb;
    private AudioSource audioSource;

    public AudioClip clip;

    public float jumpForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
                rb.velocity = new Vector3(0, 0, -45);
                rb.AddForce(0, jumpForce, 0);
                audioSource.PlayOneShot(clip);

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        ManagerMery.lives = ManagerMery.lives - 1;
        SceneManager.LoadScene("FlappyBirdMery");

        if (ManagerMery.lives == 0)
        {
            SceneManager.LoadScene("GameOverMery");
        }
    }
}
