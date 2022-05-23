using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;
    private void Start()
    {
        //まずはゲームオブジェクトを探して変数に控えておく
        GameObject managerObject = GameObject.Find("GameManager");
        //控えておいたゲームオブジェクトに対してGetComponentでGameManagerコンポーネントを取得
        gameManager=managerObject.GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }
}