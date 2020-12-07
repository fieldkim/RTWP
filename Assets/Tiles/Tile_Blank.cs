using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile_Blank : Tile {
	public override void Init(int x, int y) {
		base.Init(x, y);
		tileName = "Blank";
	}
}
