using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void GoToMainScene()
    {
        SceneManager.LoadScene(1);
    }
}
