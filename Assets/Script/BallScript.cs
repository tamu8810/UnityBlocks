using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    //�{�[���̈ړ��̑������w��
    public float speed = 5f;
    Rigidbody myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        //Rigidbody�ɃA�N�Z�X���ĕϐ��ɕێ����Ă���
        myRigidBody = GetComponent<Rigidbody>();
        //�E�΂߂S�T�x�ɐi��
        myRigidBody.velocity = new Vector3(speed,speed,0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
