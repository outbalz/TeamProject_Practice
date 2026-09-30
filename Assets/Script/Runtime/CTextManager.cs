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
		List<string> stringList1 = new List<string>(_textList);
		List<string> stringList2 = new List<string>();

		if (stringList1.Count > 20)
		{
			stringList1.RemoveRange(20, stringList1.Count - 20);

			stringList2 = new List<string>(_textList);
            stringList2.RemoveRange(0, 20);

		}

		_controller_1.SetText(stringList1);
		_controller_2.SetText(stringList2);
	}
}
