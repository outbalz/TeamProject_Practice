using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CText2Controller : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    private List<string> _textList;

    public void SetText(List<string> textList)
    {
        _textList = textList;
    }


}
