using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Drawing : MonoBehaviour {

    /// <summary>
    /// 乱数最小値
    /// </summary>
    private static int RandMin = 0;

    /// <summary>
    /// 乱数最大値
    /// </summary>
    private static int RandMax = 65535;

    /// <summary>
    /// 整数の乱数を返す
    /// </summary>
    private int iRandNum = 0;

    /// <summary>
    /// 母数
    /// </summary>
    [SerializeField]
    private int Parameter = 50;

    /// <summary>
    /// 結果発表おおおおお！！！！！
    /// </summary>
    [SerializeField]
    private Text Result;

    /// <summary>
    /// 最初に呼ぶやつ
    /// </summary>
    void Start ()
    {
	
	}
	
	/// <summary>
    /// 毎フレーム呼ばれるやつ
    /// </summary>
	void Update ()
    {
	
	}

    /// <summary>
    /// 抽選を引く
    /// </summary>
    public void Subtract()
    {
        iRandNum = Random.Range(RandMin, RandMax);

        if(iRandNum % Parameter == 0)
        {
            Result.text = "あたり";
            Debug.Log("あたり");
        }
        else
        {
            Result.text = "ハズレ";
            Debug.Log("ハズレ");
        }

        Debug.Log(iRandNum % Parameter);
    }
}
