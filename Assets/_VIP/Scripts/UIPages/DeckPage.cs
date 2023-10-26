using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class DeckPage : UIPage
{
	public Image cardPanel;
	public Transform startPos;
	public Transform endPos;


	protected override string uiPath => "DeckPage";

	protected override void OnAwake()
	{
		cardPanel = transform.Find("CardPanel").GetComponent<Image>();
		startPos = transform.Find("StartPos").GetComponent<Transform>();
		endPos = transform.Find("EndPos").GetComponent<Transform>();

		OnStart();
	}
}