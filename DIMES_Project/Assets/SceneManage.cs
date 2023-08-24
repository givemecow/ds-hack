using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ClickManager : MonoBehaviour
{

    List<string> sc = new List<string>(new string[] { "Level1", "Level2", "Level3", "MiniGame2" });
    public void MoveLevel()
    {
        SceneManager.LoadScene(""); // 레벨 씬 추가 후 변경 피룡
    }

    public void MoveMain1()
    {
        SceneManager.LoadScene("Level1");
    }


    public void MoveMini1()
    {
        SceneManager.LoadScene("Room 1"); // 미니게임1 추가 후 변경 필요
    }

    public void MoveMain2()
    {
        SceneManager.LoadScene("Level2");
    }

    public void MoveMain3()
    {
        SceneManager.LoadScene("Level3");
    }

    public void MoveMini2()
    {
        SceneManager.LoadScene("MiniGame2");
    }

    public void NextScene(string str)
    {
        SceneManager.LoadScene(str);
    }
}
