using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelperFunctions : MonoBehaviour {

	public static int width = 10;
	public static int height = 20;
	public static Transform[,] grid = new Transform[width, height];

	public static Vector2 roundVector2(Vector2 v) {
		return new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
	}

	public static bool insideBorder(Vector2 pos) {
		return ((int)pos.x >= 0 && (int)pos.x < width && (int)pos.y >= 0);
	}

}
