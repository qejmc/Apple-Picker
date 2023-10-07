using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Difficulty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void easy()
    {
        SceneManager.LoadScene("_Scene_0");
        AppleTree.speed = 8f;
        AppleTree.banana_drop_chance = 0.0f;
        AppleTree.appleDropDelay = 1f;
    }

    public void medium() 
    {
        SceneManager.LoadScene("_Scene_0");
        AppleTree.speed = 13f;
        AppleTree.banana_drop_chance = 0.3f;
        AppleTree.appleDropDelay = 0.4f;
    }

    public void hard()
    {
        SceneManager.LoadScene("_Scene_0");
        AppleTree.speed = 20f;
        AppleTree.banana_drop_chance = 0.5f;
        AppleTree.appleDropDelay = 0.3f;
    }
}
