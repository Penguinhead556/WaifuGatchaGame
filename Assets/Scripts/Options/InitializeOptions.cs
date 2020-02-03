using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InitializeOptions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("GameSounds").GetComponent<Slider>().value = PlayerPrefs.GetFloat("GameSounds");
        GameObject.Find("GameMusic").GetComponent<Slider>().value = PlayerPrefs.GetFloat("GameMusic");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
