using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControls : MonoBehaviour
{
    public GameObject Bullet;

    public void shootBullet()
    {
        GameObject Hero = GameObject.Find("Hero");

        GameObject a = Instantiate(Bullet) as GameObject;
        a.transform.position = new Vector2(Hero.transform.position.x, Hero.transform.position.y);
    }
}
