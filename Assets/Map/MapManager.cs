using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : Singleton<MapManager> {

	[SerializeField]
	List<GameObject> tileGO;
	public List<GameObject> TileGO { get {
			return tileGO;
		}
	}


}
