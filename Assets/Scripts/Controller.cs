﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject instructions;
    [SerializeField]
    private GameObject quit;
	[SerializeField]
	private GameObject pause;
	[SerializeField]
	private GameObject controls;
	[SerializeField]
	private GameObject end;
    private bool timeOn;
    private bool exit;
    // Use this for initialization
    void Start()
    {
		menu.SetActive (true);
		instructions.SetActive (true);
		quit.SetActive (false);
		controls.SetActive (false);
		end.SetActive (false);
		pause.SetActive (false);
        timeOn = true;
        exit = false;
    }

	public void ControlMenu(){
		pause.SetActive (false);
		controls.SetActive (true);
	}

	public void QuitMenu(){
		pause.SetActive (false);
		quit.SetActive (true);
	}

	public void Continue(){
		timeOn = !timeOn;
		Time.timeScale = 1;
		menu.SetActive (true);
		pause.SetActive (false);
		Cursor.visible = false;
	}

	public void QuitNo(){
		quit.SetActive (false);
		pause.SetActive (true);
	}
		
	public void QuitYes(){

	}

	public void ControlsBack(){
		controls.SetActive (false);
		pause.SetActive (true);
	}
    // Update is called once per frame
    void Update()
    {
		if (timeOn) {
			if (Input.GetKeyDown ("p")) {
				timeOn = !timeOn;
				Time.timeScale = 0;
				menu.SetActive (false);
				pause.SetActive (true);
				instructions.SetActive (false);
				Cursor.visible = true;
			}
		} else {
			if (Input.GetKeyDown ("p")) {
				timeOn = !timeOn;
				Time.timeScale = 1;
				menu.SetActive (true);
				pause.SetActive (false);
				Cursor.visible = false;
			}
		}

//		if (!exit)
//        {
//            if (Input.GetKeyDown("p"))
//            {
//                isOn = !isOn;
//                instructions.SetActive(isOn);
//                menu.SetActive(!isOn);
//            }
//
//            if (Input.GetKeyDown("q"))
//            {
//                quit.SetActive(true);
//                instructions.SetActive(false);
//                menu.SetActive(false);
//                Time.timeScale = 0;
//                exit = true;
//            }
//        }
//        else
//        {
//            if (Input.GetKeyDown("y"))
//            {
//                SceneManager.LoadScene("Truck");
//                Time.timeScale = 1;
//            }
//            if (Input.GetKeyDown("n"))
//            {
//                Time.timeScale = 1;
//                exit = false;
//                quit.SetActive(false);
//                instructions.SetActive(isOn);
//                menu.SetActive(!isOn);
//
//            }
//        }
    }
}


