﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPBar : MonoBehaviour
{
    public float HP;

    // Start is called before the first frame update
    void Start()
    {
        HP = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = HP.ToString() + "/1000";

        if (HP <= 0)
        {
            SceneManager.LoadScene("HomePage");
        }
    }
}
