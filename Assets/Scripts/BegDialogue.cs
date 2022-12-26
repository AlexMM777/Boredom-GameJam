using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BegDialogue : MonoBehaviour
{
    public GameObject dialogue1, dialogue2, blackImg;

    void Start()
    {
        SpriteRenderer sr = blackImg.GetComponent<SpriteRenderer>();
        dialogue1.SetActive(false);
        dialogue2.SetActive(false);
    }

    void Update()
    {
       
    }
    public void StartBegDialogue()
    {
        StartCoroutine(ExecuteAfterTime(10));
    }

    IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        dialogue1.SetActive(true);
        dialogue2.SetActive(false);
        yield return new WaitForSeconds(time);
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        yield return new WaitForSeconds(time+5);
        StartCoroutine(FadeIn());
    }

    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(2f);
        byte alpha = 0; //max:255

        while(alpha < 255)
        { 
            blackImg.GetComponent<Image>().color = new Color32(0, 0, 0, alpha);
            alpha++;
            //Debug.Log(alpha.ToString());
            yield return new WaitForSeconds(0.004f);
        }
    }
}
