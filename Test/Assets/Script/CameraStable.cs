using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

	// Double Slashes Are For Notes
	// Float = Decimal Number

	public GameObject TheCar;
	public float CarX;
	public float CarY;
	public float CarZ;

	void Update () {
		CarX = TheCar.transform.eulerAngles.x;
		CarY = TheCar.transform.eulerAngles.y;
		CarZ = TheCar.transform.eulerAngles.x;

		transform.eulerAngles = new Vector3 (CarX - CarX, CarY, CarZ - CarZ);


	}
}
