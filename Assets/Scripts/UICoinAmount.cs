using UnityEngine;
using TMPro;

public class UICoinAmount : MonoBehaviour
{
    [SerializeField] private CoinCounter _coinAmountToUI;
    [SerializeField] private TMP_Text _score;

    public void DisplayCoinAmount()
    {
        _score.text = _coinAmountToUI.CoinAmount.ToString();
    }
}
