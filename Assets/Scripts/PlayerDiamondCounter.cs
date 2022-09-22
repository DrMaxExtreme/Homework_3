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

        _scoreText.text = _diamondsCount + " / " + _maxDiamonds;
    }

    public void DiamondPickup()
    {
        _diamondsCount++;

        _scoreText.text = _diamondsCount + " / " + _maxDiamonds;
    }
}
