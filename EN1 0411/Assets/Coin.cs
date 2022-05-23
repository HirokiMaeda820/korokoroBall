using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;
    private void Start()
    {
        //�܂��̓Q�[���I�u�W�F�N�g��T���ĕϐ��ɍT���Ă���
        GameObject managerObject = GameObject.Find("GameManager");
        //�T���Ă������Q�[���I�u�W�F�N�g�ɑ΂���GetComponent��GameManager�R���|�[�l���g���擾
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