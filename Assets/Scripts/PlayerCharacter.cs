using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private int hairNum, beardNum, topNum, bottomNum, hatNum, jewelryNum, shoesNum;
    #region Meshes
    public GameObject skin_head;
    public GameObject skin_body;

    public GameObject crowbar;
    public GameObject fireaxe;
    public GameObject glock;
    public GameObject phone;

    public GameObject[] beards;
    public GameObject[] hats;
    public GameObject[] glasses;
    public GameObject[] necklace;
    public GameObject[] tops;
    public GameObject[] bottoms;
    public GameObject[] shoes;
    public GameObject[] hairs;
    #endregion
    #region Textures
    public Texture[] skin_textures;

    public Texture[] beard_textures;

    public Texture[] hair_a_textures;
    public Texture[] hair_b_textures;
    public Texture[] hair_c_textures;
    public Texture[] hair_d_textures;
    public Texture[] hair_e_textures;

    public Texture[] cap_textures;
    public Texture[] cap2_textures;
    public Texture[] cap3_textures;

    public Texture[] chain1_textures;
    public Texture[] chain2_textures;
    public Texture[] chain3_textures;
    public Texture[] scarf_textures;

    public Texture[] glasses_texture;

    public Texture[] jacket_textures;
    public Texture[] pullover_textures;
    public Texture[] shirt_textures;
    public Texture[] tank_top_textures;
    public Texture[] t_shirt_textures;


    public Texture[] shoes1_textures;
    public Texture[] shoes2_textures;
    public Texture[] shoes3_textures;

    public Texture[] shortpants_textures;
    public Texture[] trousers_textures;
    #endregion
    public Animator anim;

    void Start()
    {
    }

    void Update()
    {
    }

    #region Textures
    public void Skin(int skinNum)
    {
        //total skins: 6
        skin_head.GetComponent<Renderer>().materials[0].mainTexture = skin_textures[skinNum];
        skin_body.GetComponent<Renderer>().materials[0].mainTexture = skin_textures[skinNum];
         
    }

    public void HairTexture(int hairTextNum)
    {
        //total hair: 6
        if (hairNum == 1 && hairTextNum < hair_a_textures.Length)
        {
            hairs[hairNum].GetComponent<Renderer>().materials[0].mainTexture = hair_a_textures[hairTextNum];
        }
        if (hairNum == 2 && hairTextNum < hair_b_textures.Length)
        {
            hairs[hairNum].GetComponent<Renderer>().materials[0].mainTexture = hair_b_textures[hairTextNum];
        }
        if (hairNum == 3 && hairTextNum < hair_c_textures.Length)
        {
            hairs[hairNum].GetComponent<Renderer>().materials[0].mainTexture = hair_c_textures[hairTextNum];
        }
        if (hairNum == 4 && hairTextNum < hair_d_textures.Length)
        {
            hairs[hairNum].GetComponent<Renderer>().materials[0].mainTexture = hair_d_textures[hairTextNum];
        }
        if (hairNum == 5 && hairTextNum < hair_e_textures.Length)
        {
            hairs[hairNum].GetComponent<Renderer>().materials[0].mainTexture = hair_e_textures[hairTextNum];
        }
    }

    public void BeardTexture(int beardTextNum)
    {
        beards[beardNum].GetComponent<Renderer>().materials[0].mainTexture = beard_textures[beardTextNum];
    }

    public void TopTexture(int topTextNum)
    {
        //total tops: 5
        if (topNum == 0 && topTextNum < jacket_textures.Length)
        {
            tops[topNum].GetComponent<Renderer>().materials[0].mainTexture = jacket_textures[topTextNum];
        }
        if (topNum == 1 && topTextNum < pullover_textures.Length)
        {
            tops[topNum].GetComponent<Renderer>().materials[0].mainTexture = pullover_textures[topTextNum];
        }
        if (topNum == 2 && topTextNum < shirt_textures.Length)
        {
            tops[topNum].GetComponent<Renderer>().materials[0].mainTexture = shirt_textures[topTextNum];
        }
        if (topNum == 3 && topTextNum < tank_top_textures.Length)
        {
            tops[topNum].GetComponent<Renderer>().materials[0].mainTexture = tank_top_textures[topTextNum];
        }
        if (topNum == 4 && topTextNum < t_shirt_textures.Length)
        {
            tops[topNum].GetComponent<Renderer>().materials[0].mainTexture = t_shirt_textures[topTextNum];
        }
    }

    public void BottomTexture(int bottomTextNum)
    {
        //total bottoms: 2
        if (bottomNum == 0 && bottomTextNum < shortpants_textures.Length)
        {
            bottoms[bottomNum].GetComponent<Renderer>().materials[0].mainTexture = shortpants_textures[bottomTextNum];
        }
        if (bottomNum == 1 && bottomTextNum < trousers_textures.Length)
        {
            bottoms[bottomNum].GetComponent<Renderer>().materials[0].mainTexture = trousers_textures[bottomTextNum];
        }
    }

    public void HatTexture(int hatTextNum)
    {
        //total hats: 3
        if (hatNum == 1 && hatTextNum < cap_textures.Length)
        {
            hats[hatNum].GetComponent<Renderer>().materials[0].mainTexture = cap_textures[hatTextNum];
        }
        if (hatNum == 2 && hatTextNum < cap2_textures.Length)
        {
            hats[hatNum].GetComponent<Renderer>().materials[0].mainTexture = cap2_textures[hatTextNum];
        }
        if (hatNum == 3 && hatTextNum < cap3_textures.Length)
        {
            hats[hatNum].GetComponent<Renderer>().materials[0].mainTexture = cap3_textures[hatTextNum];
        }
    }
    public void JewelryTexture(int jewelryTextNum)
    {
        //total jewelry: 4
        if (jewelryNum == 1 && jewelryTextNum < chain1_textures.Length)
        {
            necklace[jewelryNum].GetComponent<Renderer>().materials[0].mainTexture = chain1_textures[jewelryTextNum];
        }
        if (jewelryNum == 2 && jewelryTextNum < chain2_textures.Length)
        {
            necklace[jewelryNum].GetComponent<Renderer>().materials[0].mainTexture = chain2_textures[jewelryTextNum];
        }
        if (jewelryNum == 3 && jewelryTextNum < chain3_textures.Length)
        {
            necklace[jewelryNum].GetComponent<Renderer>().materials[0].mainTexture = chain3_textures[jewelryTextNum];
        }
        if (jewelryNum == 4 && jewelryTextNum < scarf_textures.Length)
        {
            necklace[jewelryNum].GetComponent<Renderer>().materials[0].mainTexture = scarf_textures[jewelryTextNum];
        }
    }
    public void ShoesTexture(int shoesTextNum)
    {
        //total shoes: 3
        if (shoesNum == 0 && shoesTextNum < shoes1_textures.Length)
        {
            shoes[shoesNum].GetComponent<Renderer>().materials[0].mainTexture = shoes1_textures[shoesTextNum];
        }
        if (shoesNum == 1 && shoesTextNum < shoes2_textures.Length)
        {
            shoes[shoesNum].GetComponent<Renderer>().materials[0].mainTexture = shoes2_textures[shoesTextNum];
        }
        if (shoesNum == 2 && shoesTextNum < shoes3_textures.Length)
        {
            shoes[shoesNum].GetComponent<Renderer>().materials[0].mainTexture = shoes3_textures[shoesTextNum];
        }
    }
    #endregion
    #region Meshes
    public void BeardMesh(int beardMeshNum)
    {
        //total beards: 5
        for (int i = 0; i < 5; i++)
        {
            if (i == beardMeshNum)
            {
                beardNum = i;
                beards[i].SetActive(true);
            }
            else
            {
                beards[i].SetActive(false);
            }
        }
    }

    public void HatMesh(int hatMeshNum)
    {
        //total hats: 4
        for (int i = 0; i < 4; i++)
        {
            if (i == hatMeshNum)
            {
                hatNum = i;
                hats[i].SetActive(true);
            }
            else
            {
                hats[i].SetActive(false);
            }
        }
    }

    public void GlassesMesh(int glassesMeshNum)
    {
        //total glasses: 2
        for (int i = 0; i < 2; i++)
        {
            if (i == glassesMeshNum)
            {
                glasses[i].SetActive(true);
            }
            else
            {
                glasses[i].SetActive(false);
            }
        }
    }

    public void JewelryMesh(int jewelryMeshNum)
    {
        //total jewelry: 5
        for (int i = 0; i < 5; i++)
        {
            if (i == jewelryMeshNum)
            {
                jewelryNum = i;
                necklace[i].SetActive(true);
            }
            else
            {
                necklace[i].SetActive(false);
            }
        }
    }

    public void TopMesh(int topsMeshNum)
    {
        //total tops: 5
        for (int i = 0; i < 5; i++)
        {
            if (i == topsMeshNum)
            {
                topNum = i;
                tops[i].SetActive(true);
            }
            else
            {
                tops[i].SetActive(false);
            }
        }
    }

    public void BottomMesh(int bottomMeshNum)
    {
        //total bottoms: 2
        for (int i = 0; i < 2; i++)
        {
            if (i == bottomMeshNum)
            {
                bottomNum = i;
                bottoms[i].SetActive(true);
            }
            else
            {
                bottoms[i].SetActive(false);
            }
        }
    }

    public void ShoesMesh(int shoesMeshNum)
    {
        //total shoes: 3
        for (int i = 0; i < 3; i++)
        {
            if (i == shoesMeshNum)
            {
                shoesNum = i;
                shoes[i].SetActive(true);
            }
            else
            {
                shoes[i].SetActive(false);
            }
        }
    }

    public void HairMesh(int hairMeshNum)
    {
        //total hair: 6
        for (int i = 0; i < 6; i++)
        {
            if (i == hairMeshNum)
            {
                hairNum = i;
                hairs[i].SetActive(true);
            }
            else
            {
                hairs[i].SetActive(false);
            }
        }
    }
    #endregion

    public void RemoveHead()
    {
        foreach (GameObject obj in beards)
        {
            if (obj.GetComponent<SkinnedMeshRenderer>() != null)
            {
                obj.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            }
        }
        foreach (GameObject obj in hats)
        {
            if (obj.GetComponent<SkinnedMeshRenderer>() != null)
            {
                obj.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            }
        }
        foreach (GameObject obj in glasses)
        {
            if (obj.GetComponent<SkinnedMeshRenderer>() != null)
            {
                obj.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            }
        }
        foreach (GameObject obj in hairs)
        {
            if (obj.GetComponent<SkinnedMeshRenderer>() != null)
            {
                obj.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
            }
        }
        skin_head.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
    }

    public void ShowHead()
    {
        foreach (GameObject obj in beards)
        {
            if (obj.GetComponent<SkinnedMeshRenderer>() != null)
            {
                obj.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            }
        }
        foreach (GameObject obj in hats)
        {
            if (obj.GetComponent<SkinnedMeshRenderer>() != null)
            {
                obj.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            }
        }
        foreach (GameObject obj in glasses)
        {
            if (obj.GetComponent<SkinnedMeshRenderer>() != null)
            {
                obj.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            }
        }
        foreach (GameObject obj in hairs)
        {
            if (obj.GetComponent<SkinnedMeshRenderer>() != null)
            {
                obj.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            }
        }
        skin_head.GetComponent<SkinnedMeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
    }

    public void PlayerSit()
    {
        anim.SetBool("isWalking", false);
        anim.SetBool("isRunning", false);
        anim.SetBool("isSitting", true);
    }
    public void PlayerWalk()
    {
        anim.SetBool("isWalking", true);
        anim.SetBool("isRunning", false);
        anim.SetBool("isSitting", false);
    }
    public void PlayerRun()
    {
        anim.SetBool("isWalking", false); 
        anim.SetBool("isRunning", true);
        anim.SetBool("isSitting", false);
    }
    public void PlayerIdle()
    {
        anim.SetBool("isWalking", false);
        anim.SetBool("isRunning", false);
        anim.SetBool("isSitting", false);
    }
}
