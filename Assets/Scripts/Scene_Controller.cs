using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Controller : MonoBehaviour
{
    public static int level_number=1;
    public static void NextLevel()
    {
        SceneManager.LoadScene("Nivel" + level_number);
        level_number++;
    }

    public void Inicio()
    {
        SceneManager.LoadScene("Inicio");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
