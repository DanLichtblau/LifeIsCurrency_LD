using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Canvas mainUI;
    public Canvas vetShopCanvas;

    [SerializeField]
    private TextMeshProUGUI lifeTotal;

    [SerializeField]
    private GameManager gameManager;

    void Start()
    {
        lifeTotal.text = ("Life: " + gameManager.lifeTotal);
    }

    public void EnableVetCavnas()
    {
        vetShopCanvas.transform.gameObject.SetActive(true);
    }

    public void DisableVetCanvas()
    {
        vetShopCanvas.transform.gameObject.SetActive(false);
    }
}
