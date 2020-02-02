using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.transform.tag != "Hero")
        {
            GameObject.Find("HP").GetComponent<HPBar>().HP -= 10.0f; ;
            Destroy(col.gameObject);
        } 
    }
}
