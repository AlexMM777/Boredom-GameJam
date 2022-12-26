using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerAI : MonoBehaviour
{
    private GameObject playerBody, playerHeadBone;
    public GameObject shootFrom;
    public GameObject laser;
    public GameObject deathMenu;
    public TMP_Text healthLabel;
    public TMP_Text scoreLabel;
    public float playerHealth;
    public float score;
    public AudioClip[] shootingAudio;
    public int index;
    public AudioSource audioSource;

    void Start()
    {
        playerBody = GameObject.Find("PlayerCharacter");
        playerHeadBone = GameObject.Find("Bone.006");
        playerBody.GetComponent<ObjectRotator>().enabled = false;
        playerBody.transform.position = this.transform.position;
        playerBody.transform.rotation = this.transform.rotation;
        playerBody.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - 0.867f, this.transform.position.z);
        playerBody.transform.SetParent(this.transform);
        playerBody.GetComponent<PlayerCharacter>().RemoveHead();
        playerHealth = 100;
        deathMenu.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()
    {
        scoreLabel.text = score.ToString();
        if (playerHealth <= 0)
        {
            healthLabel.text = "";
            deathMenu.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            healthLabel.text = playerHealth.ToString() + "% ";

            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    playerBody.GetComponent<PlayerCharacter>().PlayerRun();
                    //Debug.Log("WORK");
                }
                else
                {
                    playerBody.GetComponent<PlayerCharacter>().PlayerWalk();
                }
            }
            if (!(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D)))
            {
                playerBody.GetComponent<PlayerCharacter>().PlayerIdle();
            }

            if (Input.GetMouseButtonDown(0))
            {
                index = Random.Range(0, shootingAudio.Length);
                audioSource.clip = shootingAudio[index];
                audioSource.Play();
                Instantiate(laser, shootFrom.transform.position, shootFrom.transform.rotation);
            }
        }
    }
}
