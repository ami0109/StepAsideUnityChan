using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanItemDestroy : MonoBehaviour {

    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float difference;

    // Use this for initialization
    void Start () {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //Unityちゃんとアイテムの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

    }
	
	// Update is called once per frame
	void Update () {

        //自分の位置がユニティちゃんより後ろになったら破棄する
        if (this.transform.position.z<this.unitychan.transform.position.z-5)
        {
            //接触した自身のオブジェクトを破棄
            Destroy(this.gameObject); 
        }
	}
}
