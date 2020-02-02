using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveSetting : MonoBehaviour
{
    public void gameSoundSlider()
    {
        float SliderValue = GameObject.Find("GameSounds").GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("GameSounds", SliderValue);
        PlayerPrefs.Save();
    }

    public void gameMusicSlider()
    {
        float SliderValue = GameObject.Find("GameMusic").GetComponent<Slider>().value;
        PlayerPrefs.SetFloat("GameMusic", SliderValue);
        PlayerPrefs.Save();
    }

    public void gameSoundMute()
    {
        if (PlayerPrefs.GetInt("GameSoundsMute") == 0)
        {
            PlayerPrefs.SetInt("GameSoundsMute", 1);
        }
        else
        {
            PlayerPrefs.SetInt("GameSoundsMute", 0);
        }
        PlayerPrefs.Save();
    }

    public void gameMusicMute()
    {
        if (PlayerPrefs.GetInt("GameMusicMute") == 0)
        {
            PlayerPrefs.SetInt("GameMusicMute", 1);
        }
        else
        {
            PlayerPrefs.SetInt("GameMusicMute", 0);
        }
        PlayerPrefs.Save();
    }

    public void resetDefault()
    {
        GameObject.Find("GameSounds").GetComponent<Slider>().value = (float)0.5;
        GameObject.Find("GameMusic").GetComponent<Slider>().value = (float)0.5;

        PlayerPrefs.SetFloat("GameSounds", (float)0.5);
        PlayerPrefs.SetFloat("GameMusic", (float)0.5);
        PlayerPrefs.SetInt("GameSoundsMute", 0);
        PlayerPrefs.SetInt("GameMusicMute", 0);
        PlayerPrefs.Save();
    }

    public void okButton()
    {
        string scene = PlayerPrefs.GetString("PreviousScene");
        SceneManager.LoadScene(scene);
    }

}
