using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResultSceneController : MonoBehaviour
{
    //�e��I�u�W�F�N�g�̐���
    public GameObject scoreTextObject;      //�X�R�A
    public GameObject gameResultObject;     //�Q�[���I�[�o�[���Q�[���N���A

    // Start is called before the first frame update
    void Start()
    {
        //�e�팋�ʂ��I�u�W�F�N�g�ɓn��

        this.scoreTextObject.GetComponent<TextMeshProUGUI>().text = "SCORE : "+ SceneData.score;


        //GameOver
        if (SceneData.totalBlocks == 0 )
        {
            this.gameResultObject.GetComponent<TextMeshProUGUI>().text= "GAME CLEAR";
            this.gameResultObject.GetComponent<TextMeshProUGUI>().color = Color.yellow;
        }
        else
        {
            this.gameResultObject.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
            this.gameResultObject.GetComponent<TextMeshProUGUI>().color = Color.red;

        }
    }

    public void OnStartButtonPressed()
    {
        GameManager.instance.ReturnToStart();
    }
}
