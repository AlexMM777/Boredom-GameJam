using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManagerCustom : MonoBehaviour
{
    private float fov;
    private bool inCharacterSelect;
    public GameObject characterSelectScreen, characterSelectCam, othPlayerBody, playerController, playerBody;
    public GameObject dialogue1, dialogue2, blackImg, playerGoTo;
    public string sceneToLoad;

    void Start()
    {
        fov = 60;
        Camera.main.fieldOfView = fov;
        inCharacterSelect = true;
    }

    void Update()
    {
        if (inCharacterSelect)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
            {
                if (fov <= 60)
                {
                    fov--;
                }
                else
                {
                    fov = 60;
                }
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
            {
                if (fov <= 60)
                {
                    fov++;
                }
                else
                {
                    fov = 60;
                }
            }
            Camera.main.fieldOfView = fov;
        }
    }

    public void StartGame()
    {
        GameObject go = GameObject.Instantiate(playerBody);
        go.transform.position = playerGoTo.transform.position;
        Vector3 eulerRotation = new Vector3(go.transform.eulerAngles.x, playerGoTo.transform.eulerAngles.y, go.transform.eulerAngles.z);
        go.transform.rotation = Quaternion.Euler(eulerRotation);
        go.GetComponent<PlayerCharacter>().RemoveHead();
        go.GetComponent<PlayerCharacter>().PlayerSit();
        inCharacterSelect = false;
        characterSelectScreen.SetActive(false);
        characterSelectCam.SetActive(false);
        playerController.SetActive(true);
        StartCoroutine(StartBegDialogue(10));
    }

    IEnumerator StartBegDialogue(float time)
    {
        yield return new WaitForSeconds(time);
        dialogue1.SetActive(true);
        dialogue2.SetActive(false);
        yield return new WaitForSeconds(time);
        dialogue1.SetActive(false);
        dialogue2.SetActive(true);
        yield return new WaitForSeconds(time + 5);
        StartCoroutine(FadeIn());
    }
    IEnumerator FadeIn()
    {
        yield return new WaitForSeconds(2f);
        byte alpha = 0; //max:255

        while (alpha < 255)
        {
            blackImg.GetComponent<Image>().color = new Color32(0, 0, 0, alpha);
            alpha++;
            //Debug.Log(alpha.ToString());
            yield return new WaitForSeconds(0.004f);
        }
        DontDestroyOnLoad(playerBody);
        SceneManager.LoadScene(sceneToLoad);
    }
}
