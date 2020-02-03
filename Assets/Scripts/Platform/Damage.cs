using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Damage : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D col)
    {
        string tag = col.gameObject.transform.tag;
        if ( tag == "Ally" || tag == "Particle")
        {
            GameObject.Find("HP").GetComponent<HPBar>().HP -= 10.0f; ;

            GameObject.Find("EnemyHealth").GetComponent<Slider>().value = GameObject.Find("HP").GetComponent<HPBar>().HP/1000;

            Destroy(col.gameObject);
        } 
    }
}
