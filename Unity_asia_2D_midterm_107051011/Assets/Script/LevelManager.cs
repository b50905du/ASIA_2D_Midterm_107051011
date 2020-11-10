﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void NextLevel(string namelevel) 
    {
        SceneManager.LoadScene(namelevel);
    }
    public void BackToMenu() 
    {
        SceneManager.LoadScene("封面選單");
    }
    public void QuitGame() 
    {
        Application.Quit();
    }
}
