using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


// 맵Batch는 맵 제너레이트를 여러개 연결한 자동 생성 패키지.
// 맵Batch 스스로가 타일 분류
public class MapBatch : MonoBehaviour {
	string seedString;
	Vector2Int size;
	int[][] mapInt;
	bool[][] maskMap;

	// 생성자. 말 그대로 초기화 수행. 오버라이드 하지 않는다.
	public MapBatch(string seedString, Vector2Int vector2Int) {
		if (seedString == null) {
			seedString = UnityEngine.Random.Range(Int32.MinValue, Int32.MaxValue).GetHashCode().ToString();
		}
		this.seedString = seedString;
		mapInt = new int[size.x][];
		for (int i = 0; i < size.x; i++) {
			mapInt[i] = new int[size.y];
		}
	}

	// 실제 배치 실행.
	public virtual Map GenerateMap() {
		// Pattern_Base로 설치하고
		mapInt = Pattern_Base.Instance.Generate(mapInt, ref maskMap);

		Tile[][] generatedTiles = GetTiles(mapInt);

		Map map = new Map();
		map.Init(seedString, generatedTiles);
		return map;
	}

	public Tile[][] GetTiles(int[][] mapInt) {
		Tile[][] generatedTiles = new Tile[size.x][];
		for (int i = 0; i < size.x; i++) {
			generatedTiles[i] = new Tile[size.y];
			for (int i2 = 0; i2 < size.y; i2++) {
				GameObject tileGameObject = Instantiate(MapManager.Instance.TileGO[mapInt[i][i2]]);
				tileGameObject.GetComponent<Tile>().Init(i, i2);
			}
		}
		return generatedTiles;
	}
}
