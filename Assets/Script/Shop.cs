using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Shop : MonoBehaviour {


    /// <summary>
    /// ショップ画面
    /// </summary>
    [SerializeField]
    private GameObject ShopWindows = null;


    /// <summary>
    /// 開くボタン
    /// </summary>
    [SerializeField]
    private GameObject OpenButton = null;


    /// <summary>
    /// 閉じるボタン
    /// </summary>
    [SerializeField]
    private GameObject CloseButton = null;

    /// <summary>
    /// 最初に呼ぶやつ
    /// </summary>
    void Start()
    {

    }

    /// <summary>
    /// 毎フレーム呼ばれるやつ
    /// </summary>
    void Update()
    {

    }

    /// <summary>
    /// Shopの画面
    /// </summary>
    public void OpenWindow()
    {
        ShopWindows.SetActive(true);
        OpenButton.SetActive(false);
    }

    /// <summary>
    /// Shopの画面
    /// </summary>
    public void CloseWindow()
    {
        ShopWindows.SetActive(false);
        OpenButton.SetActive(true);
    }

}
