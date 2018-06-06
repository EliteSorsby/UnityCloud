using UnityEngine;
using UnityStandardAssets.Vehicles.Car;


    public class CarControlActive : MonoBehaviour
    {

        public GameObject CarControl;

        void Start() {

            CarControl.GetComponent<CarController>().enabled = true;
        }
    }


