using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour {

    //**************課題用コードＳ*************************************
    //Unityちゃんのオブジェクト
    private GameObject UnityChan;
    //アイテムを生成し始める距離
    private int ItemGeneLen = 40;
    //一度に生成をする長さ
    private int GeneUnit = 15;
    //次の生成を開始する位置
    private int NextPos;
    //**************課題用コードＥ*************************************
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //cornPrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = -160;
    //ゴール地点
    private int goalPos = 120;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;

    // Use this for initialization
    void Start () {
        //**************課題用コードＳ*************************************
        this.UnityChan = GameObject.Find("unitychan");
        this.NextPos = startPos;
        //**************課題用コードＥ*************************************

        //**************課題用コード削除Ｓ*********************************
        //一定の距離ごとにアイテムを生成
        /*for (int i = startPos; i < goalPos; i += 15){
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(0, 10);
            if (num <= 1){
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else{

                //レーンごとにアイテムを生成
                for (int j = -1; j < 2; j++){
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //50%コイン配置:30%車配置:10%何もなし
                    if (1 <= item && item <= 6){
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9){
                        //車を生成
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
        }*/
        //**************課題用コード削除Ｅ***********************************

    }

    // Update is called once per frame
    void Update () {

        //**************課題用コードＳ*************************************

        float i = this.UnityChan.transform.position.z + ItemGeneLen;
        
        //一定の距離ごとにアイテムを生成
        if (startPos <= i && i < goalPos && this.NextPos <= i){


            //**************既存コード（修正なし）*************************************
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(0, 10);
            if (num <= 1)
            {
                //コーンをx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject cone = Instantiate(conePrefab) as GameObject;
                    cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                }
            }
            else
            {

                //レーンごとにアイテムを生成
                for (int j = -1; j < 2; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //50%コイン配置:30%車配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //コインを生成
                        GameObject coin = Instantiate(coinPrefab) as GameObject;
                        coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab) as GameObject;
                        car.transform.position = new Vector3(posRange * j, car.transform.position.y, i + offsetZ);
                    }
                }
            }
            //**************既存コード（修正なし）*************************************

            this.NextPos += this.GeneUnit;
       }

        //**************課題用コードＥ*************************************
    }
}
