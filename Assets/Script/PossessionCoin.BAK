using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PossessionCoin : MonoBehaviour {

    /// <summary>
    /// 初期コイン
    /// </summary>
    [SerializeField]
    private int InitialCoin = 50;

    /// <summary>
    /// 所持コイン
    /// </summary>
    private int CoinNumber = 0;


    [SerializeField]
    private Text CoinNumberText;

    /// <summary>
    /// 最初に呼ぶやつ
    /// </summary>
    void Start()
    {
        CoinNumber = InitialCoin;
    }

    /// <summary>
    /// 毎フレーム呼ばれるやつ
    /// </summary>
    void Update()
    {
        DrawCoin();
    }

    /// <summary>
    /// 減らす
    /// </summary>
    public void Reduce()
    {
        CoinNumber--;
    }

    /// <summary>
    /// 増やす
    /// </summary>
    public void Increase()
    {
        CoinNumber += InitialCoin;
    }

    /// <summary>
    /// 所持コイン枚数
    /// </summary>
    private void DrawCoin()
    {
        CoinNumberText.text = CoinNumber.ToString() + "枚";
    }

}
