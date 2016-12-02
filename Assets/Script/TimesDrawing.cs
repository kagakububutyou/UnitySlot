using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimesDrawing : MonoBehaviour {

    /// <summary>
    /// ハズレ回数表示用
    /// </summary>
    [SerializeField]
    private Text LoseCountText;


    /// <summary>
    /// ハズレ回数表示用
    /// </summary>
    [SerializeField]
    private Text ContinuousLoseCountText;

    /// <summary>
    /// あたり回数表示用
    /// </summary>
    [SerializeField]
    private Text HitCountText;

    /// <summary>
    /// 累計クリック回数
    /// </summary>
    [SerializeField]
    private Text TotalClickText;

    /// <summary>
    /// ハズレの回数
    /// </summary>
    private int LoseCount = 0;

    /// <summary>
    /// 連続ハズレ回数
    /// </summary>
    private int ContinuousLoseCount = 0;

    /// <summary>
    /// 当たり回数
    /// </summary>
    private int HitCount = 0;

    /// <summary>
    /// 最初に呼ぶやつ
    /// 基本初期化に使う
    /// </summary>
    void Start()
    {
        LoseCount = 0;
        HitCount = 0;
    }

    /// <summary>
    /// 毎フレーム呼ばれるやつ
    /// </summary>
    void Update()
    {
        DrawCount();
    }

    /// <summary>
    /// ハズレのとき呼ばれるやつ
    /// </summary>
    public void GetLose()
    {
        LoseCount++;
        ContinuousLoseCount++;
    }

    /// <summary>
    /// 当選回数
    /// </summary>
    public void GetHit()
    {
        HitCount++;
        ContinuousLoseCount = 0;
    }

    /// <summary>
    /// カウントの表示
    /// </summary>
    private void DrawCount()
    {
        LoseCountText.text = LoseCount.ToString() + "回ハズレ";
        ContinuousLoseCountText.text = ContinuousLoseCount.ToString() + "回連続ハズレ";
        HitCountText.text = HitCount.ToString() + "回当たり";
        TotalClickText.text = (LoseCount + HitCount).ToString() + "回クリック";
    }
}
