using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public SliderValue mastSlider;

    // Use this for initialization
    void Start() {
        mastSlider.Init(MoveMast);
    }

    // Update is called once per frame
    void Update() {
		mastSlider.Update(Input.GetAxis("Horizontal") * Time.deltaTime);
    }

    public void MoveMast(float value_) {
		Debug.Log(value_);
    }
}
