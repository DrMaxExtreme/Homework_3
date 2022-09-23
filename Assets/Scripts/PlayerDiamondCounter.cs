using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDiamondCounter : MonoBehaviour
{
    [SerializeField] private Text _scoreText;
    [SerializeField] private Transform _diamonds;

    private int _diamondsCount;
    private int _maxDiamonds;

    private void Start()
    {
        _diamondsCount = 0;
        _maxDiamonds = _diamonds.childCount;

        ShowDiamondsCount(_diamondsCount, _maxDiamonds);
    }

    public void DiamondPickup()
    {
        _diamondsCount++;

        ShowDiamondsCount(_diamondsCount, _maxDiamonds);
    }

    private void ShowDiamondsCount(int diamondsCount, int maxDiamonds)
    {
        _scoreText.text = diamondsCount + " / " + maxDiamonds;
    }
}
