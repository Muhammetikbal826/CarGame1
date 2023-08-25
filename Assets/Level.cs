using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Level : MonoBehaviour
{
     public void Level1Button()
    {
         
        SceneManager.LoadScene(2);
         
    }

    public void Level2Button()
    {
        SceneManager.LoadScene(3);
    }

    public void Level3Button()
    {
        SceneManager.LoadScene(4);
    }
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
}
