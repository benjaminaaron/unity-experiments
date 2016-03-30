using UnityEngine;
using System.Collections;

public class SphereController : MonoBehaviour {

	public float angleOffset;
	public float angle;
	public float radius;
	public float scale;

	float time;

	void Start () {
		time = 0;
	}

	public void init(float angleOffset, float angle, float radius) {
		this.angleOffset = angleOffset;
		this.radius = radius;
		this.angle = angle;

		float x = radius * Mathf.Cos (angle);
		float z = radius * Mathf.Sin (angle);
		scale = 0.5f + radius * 0.06f;
		transform.position = new Vector3 (x, scale / 2, z);
		transform.localScale = new Vector3(scale, scale, scale);
	}
	
	void Update () {
		time += Time.deltaTime;

		float factor = 1.25f + 0.25f * Mathf.Sin (time + angleOffset);
		float yFactor = factor * scale * 3;

		float x = 1 * radius * Mathf.Cos (angle + time * 0.1f * angleOffset);
		float y = yFactor + transform.localScale.y / 2 + yFactor * Mathf.Sin (angleOffset + time);
		float z = 1 * radius * Mathf.Sin (angle + time * 0.1f * angleOffset);

		transform.position = new Vector3(x, y, z);
	}

}
