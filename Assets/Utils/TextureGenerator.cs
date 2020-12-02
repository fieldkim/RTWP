using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureGenerator : MonoBehaviour {

	public enum TexturePattern {
		random,
		graidation,
	}

	// Start is called before the first frame update
	void Start() {

	}

	public static void GenerateTexture(GameObject targetObject, Vector2Int imageSize, TexturePattern texturePattern) {
		List<Color> texturePointColors = new List<Color>();
		switch (texturePattern) {
			case (TexturePattern.random):
			default:
				for(int i = 0; i < imageSize.x; i++) {
					for(int i2 = 0; i2 < imageSize.y; i2++) {
						texturePointColors.Add(new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f)));
					}
				}
				break;
			case (TexturePattern.graidation):
				for(int i = 0; i < imageSize.x; i++) {
					for(int i2 = 0; i2 < imageSize.y; i2++) {
						texturePointColors.Add(new Color((float)i2 / (float)imageSize.y, 0, 0));
					}
				}
				break;
		}

		Texture2D texture = new Texture2D(imageSize.x, imageSize.y);
		for(int i = 0; i < imageSize.x; i++) {
			for(int i2 = 0; i2 < imageSize.y; i2++) {
				texture.SetPixel(i, i2, texturePointColors[i * imageSize.y + i2]);
			}
		}
		texture.Apply();
		targetObject.GetComponent<Renderer>().material.mainTexture = texture;
	}
}
