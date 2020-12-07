using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tile : MonoBehaviour {
	protected string tileName;
	public TextMeshPro tmpro; 

	public int X { get; private set; }
	public int Y { get; private set; }


	public virtual void Init(int x, int y) {
		tileName = "Default";
		tmpro = GetComponent<TextMeshPro>();
		X = x;
		Y = y;
	}

	public void WriteString(string writingString) {
		tmpro.SetText(writingString);
	}
}
