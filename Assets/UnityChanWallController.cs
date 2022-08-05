using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityChanWallController : MonoBehaviour
{
    private GameObject unitychanObject;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のunitychanオブジェクトを取得
        this.unitychanObject = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //unitychanWallをunitychanと一緒に動かす
        this.transform.position = new Vector3(0, 0, this.unitychanObject.transform.position.z - 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        //unitychanWallが衝突したオブジェクトを削除
        if (other.gameObject.tag == "CarTag" || other.gameObject.tag == "CoinTag" || other.gameObject.tag == "TrafficConeTag")
        {
            //接触したオブジェクトを破棄
            Destroy(other.gameObject);

        }
    }
}
