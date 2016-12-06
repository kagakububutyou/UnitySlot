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
    /// カウント判定
    /// </summary>
    [SerializeField]
    private TimesDrawing timesDrawing = new TimesDrawing();

    /// <summary>
    /// 所持コイン
    /// </summary>
    [SerializeField]
    private PossessionCoin possessionCoin = new PossessionCoin();

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
    /// 当たり
    /// </summary>
    private void Hit()
    {
        timesDrawing.GetHit();
        possessionCoin.Increase();
        Result.text = "あたり";
        Debug.Log("あたり");
    }

    /// <summary>
    /// ハズレ
    /// </summary>
    private void Lose()
    {
        timesDrawing.GetLose();
        possessionCoin.Reduce();
        Result.text = "ハズレ";
        Debug.Log("ハズレ");
    }

    /// <summary>
    /// 抽選を引く
    /// </summary>
    public void Subtract()
    {
        iRandNum = Random.Range(RandMin, RandMax);

        if(iRandNum % Parameter == 0)
        {
            Hit();
        }
        else
        {
            Lose();
        }

        Debug.Log(iRandNum % Parameter);
    }
}
