using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewForkController : MonoBehaviour {

	public SliderValue mastSlider;
	public Transform mast;
	public Transform mastParent;

	public SliderValue forkSliderHorizontal;
	public SliderValue forkSliderVertical;
	public Transform fork;
	public Transform forkParent;

	// Use this for initialization
	void Start () {
		mastSlider.Init(RotateMast);
		forkSliderHorizontal.Init(MoveForkHorizontally);
		forkSliderVertical.Init(MoveForkVertically);
	}
	
	// Update is called once per frame
	void Update () {
		mastSlider.Update(Input.GetAxis("Lever1") * Time.deltaTime);
		forkSliderHorizontal.Update(Input.GetAxis("Lever2") * Time.deltaTime);
		forkSliderVertical.Update(Input.GetAxis("Lever3") * Time.deltaTime);

	}

	public void RotateMast(float value_){
		mast.transform.localRotation = Quaternion.Euler(value_, 0, 0);
	}

	public void MoveForkHorizontally(float value_){
		fork.transform.localPosition = new Vector3(value_, fork.transform.localPosition.y, fork.transform.localPosition.z);
	}

	public void MoveForkVertically(float value_){
		fork.transform.localPosition = new Vector3(fork.transform.localPosition.x, value_, fork.transform.localPosition.z);
	}
}
