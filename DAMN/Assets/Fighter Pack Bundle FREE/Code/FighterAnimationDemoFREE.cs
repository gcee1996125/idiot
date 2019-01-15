using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class FighterAnimationDemoFREE : MonoBehaviour {
	
	public Animator animator;
    public Button BtnWalkForward;
    public Button BtnBackForward;
    public Button BtnPunch;


    private Transform defaultCamTransform;
	private Vector3 resetPos;
	private Quaternion resetRot;
	private GameObject cam;
	private GameObject fighter;
    private bool motion;

    public int select = 0;

    void Start()
	{
		cam = GameObject.FindWithTag("MainCamera");
		defaultCamTransform = cam.transform;
		resetPos = defaultCamTransform.position;
		resetRot = defaultCamTransform.rotation;
		fighter = GameObject.FindWithTag("Player");
        //fighter.transform.position = new Vector3(0,0,0);
        BtnWalkForward.onClick.AddListener(WalkForward);
        BtnBackForward.onClick.AddListener(BackForward);
        BtnPunch.onClick.AddListener(Punch);
    }

    private void Update()
    {
        /*
        switch (select)
        {
            case 1:
                animator.SetBool("Walk Forward", true);
                animator.SetBool("Walk Backward", false);

                break; 
            case 2:
                animator.SetBool("Walk Backward", true);
                animator.SetBool("Walk Forward", false);

                // Console.WriteLine("Case 2");
                break;
            case 3:
                animator.SetTrigger("PunchTrigger");

                break;
            default:
                //Console.WriteLine("Default case");
                break;
        }
        */
    }

    private void WalkForward()
    {
        select = 1;
        animator.SetBool("Walk Forward", true);
        animator.SetBool("Walk Backward", false);
    }  

    private void BackForward()
    {
        select = 2;
        animator.SetBool("Walk Backward", true);
        animator.SetBool("Walk Forward", false);
    }

    private void Punch()
    {
        select = 3;
        animator.SetTrigger("PunchTrigger");
        animator.SetBool("Walk Backward", false);
        animator.SetBool("Walk Forward", false);
    }


    /*
    void OnGUI () 
	{
		if (GUI.RepeatButton (new Rect (25, 20, 100, 30), "Walk Forward")) 
		{
			animator.SetBool("Walk Forward", true);
		}
		else
		{
			animator.SetBool("Walk Forward", false);
		}

		if (GUI.RepeatButton (new Rect (25, 50, 100, 30), "Walk Backward")) 
		{
			animator.SetBool("Walk Backward", true);
		}
		else
		{
			animator.SetBool("Walk Backward", false);
		}

		if (GUI.Button (new Rect (25, 90, 100, 30), "Punch")) 
		{
			animator.SetTrigger("PunchTrigger");
		}
	}*/
}