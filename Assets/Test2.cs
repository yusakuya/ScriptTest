using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    // 魔法攻撃用の関数
    public void Magic()
    {
        if (mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

public class Test2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        Boss lastBoss = new Boss();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
        lastBoss.Magic();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
