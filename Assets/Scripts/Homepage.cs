using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Homepage : MonoBehaviour
{
    public void Start_Button()
    {
        SceneManager.LoadScene("Platform");
    }

    public void Option_Button()
    {
        PlayerPrefs.SetString("PreviousScene", "HomePage");
        PlayerPrefs.Save();
        SceneManager.LoadScene("Options");
    }
}
