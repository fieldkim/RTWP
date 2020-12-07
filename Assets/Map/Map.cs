using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour {
	public string seedString;
	public Vector2Int size;
	public System.Random random;
	public Tile[][] tiles;

	// 맵 초기화시점. 맵 스스로는 타일을 직접 형성하지 않는다. 완전히 공백에 가까운 맵이라도 항상 MapBatch에서 맵을 만들 것.
	public Map Init(string seedString, Tile[][] tiles) {
		size = new Vector2Int(tiles.Length, tiles[0].Length);
		this.seedString = seedString;
		random = new System.Random(seedString.GetHashCode());
		return this;
	}
}
