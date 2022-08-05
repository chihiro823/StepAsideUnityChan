using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanWallController : MonoBehaviour
{
    private GameObject unitychanObject;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������unitychan�I�u�W�F�N�g���擾
        this.unitychanObject = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //unitychanWall��unitychan�ƈꏏ�ɓ�����
        this.transform.position = new Vector3(0, 0, this.unitychanObject.transform.position.z - 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        //unitychanWall���Փ˂����I�u�W�F�N�g���폜
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "CoinTag" || other.gameObject.tag == "TrafficConeTag")
        {
            //�ڐG�����I�u�W�F�N�g��j��
            Destroy(other.gameObject);

        }
    }
}
