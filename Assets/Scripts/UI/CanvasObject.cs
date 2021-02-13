﻿using UnityEngine;

public class CanvasObject : MonoBehaviour
{
	public CanvasManager.CanvasNames canvasName;

	private void Awake()
	{
		CanvasManager.canvasList.Add(canvasName, GetComponent<Canvas>());
	}
}