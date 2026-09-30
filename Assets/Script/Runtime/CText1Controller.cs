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

        string result = "";


        for (int i = 0; i < _textList.Count; i++)
        {
            string space = "";

            for (int j = 0; j < i; j++)
            {
                space += "    ";
            }

            result += space + _textList[i];

            if (i < _textList.Count - 1)
            {
                result += "\n";
            }
        }

        _text.text = result;
    }
}
