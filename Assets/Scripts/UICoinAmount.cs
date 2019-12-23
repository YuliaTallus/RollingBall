using UnityEngine;
using TMPro;

public class UICoinAmount : MonoBehaviour
{
    [SerializeField]
    private CoinCounter CoinAmountToUI;

    [SerializeField]
    private TMP_Text Score;

    private void Update()
    {
        Score.text = CoinAmountToUI.CoinAmount.ToString();
    }

    private void DisplayCoinAmount() 
    {
        Score.text = CoinAmountToUI.CoinAmount.ToString();
    }
}
