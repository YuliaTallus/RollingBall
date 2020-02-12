
using UnityEngine;
using TMPro;

public class UICoinAmount : MonoBehaviour
{
    [SerializeField] private CoinCounter _coinAmountToUI;
    [SerializeField] private TMP_Text _score;

    private void Awake()
    {
        _coinAmountToUI.Changed += DisplayCoinAmount;
    }

    private void DisplayCoinAmount()
    {
        _score.text = _coinAmountToUI.CoinsAmount.ToString();
    }
}