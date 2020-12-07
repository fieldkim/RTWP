using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pattern_Base {

	// 스태틱 + 버츄얼이 안되므로 싱글톤으로 해 둔다.
	protected Pattern_Base() { }
	protected static readonly System.Lazy<Pattern_Base> _instance = new System.Lazy<Pattern_Base>(() => new Pattern_Base());
	public static Pattern_Base Instance { get { return _instance.Value; } }

	public virtual int[][] Generate(int[][] mapInt, ref bool[][] maskMap, params object[]args) {

		return mapInt;
	}
}
