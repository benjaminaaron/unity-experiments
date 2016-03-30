using UnityEditor;
using UnityEngine;
using System.Collections;

public class SpherePlacement : MonoBehaviour {


	[MenuItem("Edit/place spheres")]

	static void placeSpheres() {
		float goldenAngle = Mathf.PI * (3 - Mathf.Sqrt (5));
		float radiusIncrement = 0.08f;
		float count = 250;
		float radius = 1;

		float angle = 0;
		for (int i = 0; i < count; i++) {
			float angleOffset = i * ((2 * Mathf.PI) / count);
			GameObject sphere = Instantiate(Resources.Load("Prefabs/SpherePrefab")) as GameObject;
			sphere.GetComponent<SphereController> ().init (angleOffset, angle, radius);		
			angle += goldenAngle;
			radius += radiusIncrement;
		}
	}

}
