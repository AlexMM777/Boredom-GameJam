using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class AIController : MonoBehaviour
{
    public GameObject player;
    public float enemyHealth;
    private Animator animatorController;
    private bool isAttacking;
    public bool gotShot;
    public AudioClip[] speakingAudio;
    public int index;
    public AudioSource audioSource;
    private bool isTalking;


    void Start()
    {
        player = GameObject.Find("Player");
        animatorController = GetComponent<Animator>();
        enemyHealth = 100;
        gotShot = false;
        isAttacking = false;
    }

    void Update()
    {
        player = GameObject.Find("Player");
        if (enemyHealth <= 0)
        {
            player.GetComponent<PlayerAI>().score++;
            Destroy(this.gameObject);
        }
        else
        {
            if (!isTalking)
            {
                StartCoroutine(MakeSound());
            }
            if (gotShot)
            {
                this.GetComponent<NavMeshAgent>().isStopped = true;
            }
            else
            {
                Vector3 targetPostition = new Vector3(player.transform.position.x, this.transform.position.y, player.transform.position.z);
                this.transform.LookAt(targetPostition);
                this.GetComponent<NavMeshAgent>().destination = player.transform.position;

                if (isAttacking == false)
                {
                    if (this.GetComponent<NavMeshAgent>().velocity.magnitude < 0.15f)
                    {
                        Idle();
                    }
                    else
                    {
                        Walk();
                    }
                }
            }
            
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            isAttacking = true;
            StartCoroutine(MakeDamage());
            Attack();
        }
    }
    
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isAttacking = false;
            Idle();
        }
    }
    public void Attack()
    {

        animatorController.SetBool("isHurt", false);
        animatorController.SetBool("isWalking", false);
        animatorController.SetBool("isAttacking", true);
    }
    public void Walk()
    {
        animatorController.SetBool("isHurt", false);
        animatorController.SetBool("isWalking", true);
        animatorController.SetBool("isAttacking", false);
    }
    public void Idle()
    {
        animatorController.SetBool("isHurt", false);
        animatorController.SetBool("isWalking", false);
        animatorController.SetBool("isAttacking", false);
    }
    public void GotShot()
    {
        gotShot = true;
        animatorController.SetBool("isHurt", true);
        animatorController.SetBool("isWalking", false);
        animatorController.SetBool("isAttacking", false);
        StartCoroutine(Focus());
    }
    IEnumerator MakeDamage()
    {
        while (isAttacking)
        {
            player.GetComponent<PlayerAI>().playerHealth -= 5f;
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator Focus()
    {
        yield return new WaitForSeconds(1.5f);
        this.GetComponent<NavMeshAgent>().isStopped = false;
        gotShot = false;
    }
    IEnumerator MakeSound()
    {
        isTalking = true;
        yield return new WaitForSeconds(Random.Range(0, 6));
        index = Random.Range(0, speakingAudio.Length);
        audioSource.clip = speakingAudio[index];
        audioSource.Play();
        yield return new WaitForSeconds(speakingAudio[index].length);
        isTalking = false;
    }
}
