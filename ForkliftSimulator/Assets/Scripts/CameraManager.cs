using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{

    public List<Camera> cameras;
    private int currentCamerIndex = 0;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetButtonDown("CameraToggle")) {
            currentCamerIndex++;
            
			if (currentCamerIndex > cameras.Count - 1)
                currentCamerIndex = 0;

			cameras.ForEach(X => X.gameObject.SetActive(false));
			cameras[currentCamerIndex].gameObject.SetActive(true);
        }
    }
}
