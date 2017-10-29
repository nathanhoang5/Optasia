using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelManager : MonoBehaviour {
    public GameObject whiteSofa;
    public List<GameObject> models = new List<GameObject>();
    int active = -1;
    bool colorSwitch = false;
	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++) {
            if (i != active)
            {
                models[i].SetActive(false);
            }
        }
        if (!colorSwitch)
            whiteSofa.SetActive(false);
        else
            models[active].SetActive(false);
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && active == 0)
        {
            models[active].SetActive(colorSwitch);
            whiteSofa.SetActive(!colorSwitch);
            colorSwitch = !colorSwitch;
        }
        
    }

    public void hideAll() {
        foreach (GameObject g in models) {
            g.SetActive(false);
        }
    }

    public void showOnly(GameObject g) {

    }

    public void show(int a) {
        hideAll();
        models[a].SetActive(true);
        active = a;

    }



}
