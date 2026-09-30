using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CTextManager : MonoBehaviour
{
	#region 인스팩터
	[SerializeField] private CText1Controller _controller_1;
	[SerializeField] private CText2Controller _controller_2;


	[Space]
	[Header("Text List")]
	[SerializeField] private List<string> _textList;
	#endregion

	[ContextMenu("SetText")]
	private void SetText()
	{
		//for test
		_controller_1.SetText(_textList);
		//_controller_2.SetText();
	}
}
