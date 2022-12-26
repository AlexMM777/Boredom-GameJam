using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public GameObject playerBody, playerMain, playerShootFrom, playerCam, playerHead;
    private float camType;

    // Start is called before the first frame update
    void Start()
    {
        playerBody = GameObject.Find("PlayerCharacter");
        playerCam = GameObject.Find("PlayerFPCam");
        playerShootFrom = GameObject.Find("ShootFrom");
        playerHead = GameObject.Find("FPS_bone");
        //player1stController = GameObject.Find("Player1st");
        camType = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMain.GetComponent<PlayerAI>().playerHealth > 0)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0f) // forward
            {
                if (camType <= 60f && camType > 0f)
                {
                    camType--;
                }
                else
                {
                    camType = 0f;
                }
            }
            else if (Input.GetAxis("Mouse ScrollWheel") < 0f) // backwards
            {
                if (camType <= 60f && camType > 0f)
                {
                    camType++;
                }
                else
                {
                    camType = 60f;
                }
            }
            
            if(camType <= 25f)
            {
                //1st
                playerBody.GetComponent<PlayerCharacter>().RemoveHead();
                playerShootFrom.transform.SetParent(playerCam.transform);
                playerMain.GetComponent<SUPERCharacter.SUPERCharacterAIO>().cameraPerspective = SUPERCharacter.PerspectiveModes._1stPerson;
            }
            if(camType >= 31f)
            {
                //3rd
                playerBody.GetComponent<PlayerCharacter>().ShowHead();
                playerShootFrom.transform.SetParent(playerHead.transform);
                playerMain.GetComponent<SUPERCharacter.SUPERCharacterAIO>().cameraPerspective = SUPERCharacter.PerspectiveModes._3rdPerson;
            }
        }
    }
}
