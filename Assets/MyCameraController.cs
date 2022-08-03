using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //Unityちゃんとカメラの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんオブジェクトを取得
        //メンバ変数unitychanのthis
        this.unitychan = GameObject.Find("unitychan");

        //Unityちゃんとカメラの位置の差分を求める
        //メンバ変数differenceのthis
        //unitychanにはthisつけない？
        //アタッチしているオブジェクト（カメラ）に対するthis
        this.difference = unitychan.transform.position.z - this.transform.position.z;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        //アタッチしているオブジェクト（カメラ）に対するthis
        //メンバ変数unitychanのthis
        //differenceにはthisつけない？
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
        
    }
}
