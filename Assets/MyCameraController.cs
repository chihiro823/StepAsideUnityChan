using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{

    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    //Unity�����ƃJ�����̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����I�u�W�F�N�g���擾
        //�����o�ϐ�unitychan��this
        this.unitychan = GameObject.Find("unitychan");

        //Unity�����ƃJ�����̈ʒu�̍��������߂�
        //�����o�ϐ�difference��this
        //unitychan�ɂ�this���Ȃ��H
        //�A�^�b�`���Ă���I�u�W�F�N�g�i�J�����j�ɑ΂���this
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����̈ʒu�ɍ��킹�ăJ�����̈ʒu���ړ�
        //�A�^�b�`���Ă���I�u�W�F�N�g�i�J�����j�ɑ΂���this
        //�����o�ϐ�unitychan��this
        //difference�ɂ�this���Ȃ��H
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
        
    }
}
