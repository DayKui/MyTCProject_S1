using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public partial class LogoPage : UIPage
{
	public Slider progressSlider; // 这是我们刚才指定了WidgetID的对象


	protected override string uiPath => "LogoPage"; // 页面的名称，必须与Addressable的名称一致，否则加载不到

	protected override void OnAwake()
	{
		progressSlider = transform.Find("ProgressSlider").GetComponent<Slider>(); // 从当前节点自动在启动时找到导出的节点的Slider组件

		OnStart();
	}
}