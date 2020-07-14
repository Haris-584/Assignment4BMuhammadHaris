using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuController : MonoBehaviour
{
    public Button penguinProject;
    public Button hummingbirdProject;
    public string penguinSceneName;
    public string hummingbirdSceneName;

    public void PenguinGame()
    {
        SceneManager.LoadScene(penguinSceneName);
    }
    public void HummingbirdGame()
    {
        SceneManager.LoadScene(hummingbirdSceneName);
    }
}
