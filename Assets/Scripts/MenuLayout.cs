using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLayout : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject StartButton = GameObject.Find("Start Button");

        float buttonSizeX = StartButton.GetComponent<RectTransform>().rect.width;
        float buttonSizeY = StartButton.GetComponent<RectTransform>().rect.height;

        StartButton.transform.position = new Vector3(Screen.width - buttonSizeX/2, buttonSizeY/2, 0);

        GameObject OptionsButton = GameObject.Find("Options");

        buttonSizeX = OptionsButton.GetComponent<RectTransform>().rect.width;
        buttonSizeY = OptionsButton.GetComponent<RectTransform>().rect.height;

        OptionsButton.transform.position = new Vector3(Screen.width - buttonSizeX / 2, Screen.height - buttonSizeY / 2, 0);

        GameObject ConfigButton = GameObject.Find("Configure");

        buttonSizeX = ConfigButton.GetComponent<RectTransform>().rect.width;
        buttonSizeY = ConfigButton.GetComponent<RectTransform>().rect.height;

        ConfigButton.transform.position = new Vector3(buttonSizeX / 2, buttonSizeY / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
