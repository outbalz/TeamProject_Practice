using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CText1Controller : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    private List<string> _textList;

    public void SetText(List<string> textList)
    {
        _textList = textList;

        string firstText = _textList[0];

        string secondText = _textList[1];

        _text.text = firstText + "\n        " + secondText;
    }



}
