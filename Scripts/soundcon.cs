using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundcon : MonoBehaviour {
    public AudioClip[] aClips;
    public AudioSource myAudioSource;
    string btnName;



	// Use this for initialization
	void Start () {

        myAudioSource = GetComponent<AudioSource>();

		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.touchCount>0 && Input.touches[0].phase==TouchPhase.Began)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit Hit;
            if(Physics.Raycast(ray,out Hit))
            {
                btnName = Hit.transform.name;
                switch(btnName)
                {
                    case "Quad1":
                        myAudioSource.clip = aClips[0];
                        myAudioSource.Play();
                        break;
                    case "Quad2":
                        myAudioSource.clip = aClips[1];
                        myAudioSource.Play();
                        break;
                    case "Quad3":
                        myAudioSource.clip = aClips[2];
                        myAudioSource.Play();
                        break;
                    case "Quad4":
                        myAudioSource.clip = aClips[3];
                        myAudioSource.Play();
                        break;
                    case "Quad5":
                        myAudioSource.clip = aClips[4];
                        myAudioSource.Play();
                        break;
                    case "Quad6":
                        myAudioSource.clip = aClips[5];
                        myAudioSource.Play();
                        break;
                    case "Quad7":
                        myAudioSource.clip = aClips[6];
                        myAudioSource.Play();
                        break;
                    case "Quad8":
                        myAudioSource.clip = aClips[7];
                        myAudioSource.Play();
                        break;
                    case "Quad9":
                        myAudioSource.clip = aClips[8];
                        myAudioSource.Play();
                        break;
                    case "Quad10":
                        myAudioSource.clip = aClips[9];
                        myAudioSource.Play();
                        break;
                    case "Quad11":
                        myAudioSource.clip = aClips[10];
                        myAudioSource.Play();
                        break;
                    case "Quad12":
                        myAudioSource.clip = aClips[11];
                        myAudioSource.Play();
                        break;
                    case "Quad13":
                        myAudioSource.clip = aClips[12];
                        myAudioSource.Play();
                        break;
                    case "Quad14":
                        myAudioSource.clip = aClips[13];
                        myAudioSource.Play();
                        break;
                    case "Quad15":
                        myAudioSource.clip = aClips[14];
                        myAudioSource.Play();
                        break;
                    case "Quad16":
                        myAudioSource.clip = aClips[15];
                        myAudioSource.Play();
                        break;
                    case "Quad17":
                        myAudioSource.clip = aClips[16];
                        myAudioSource.Play();
                        break;
                    case "Quad18":
                        myAudioSource.clip = aClips[17];
                        myAudioSource.Play();
                        break;
                    case "Quad19":
                        myAudioSource.clip = aClips[18];
                        myAudioSource.Play();
                        break;
                    case "Quad20":
                        myAudioSource.clip = aClips[19];
                        myAudioSource.Play();
                        break;
                    case "Quad21":
                        myAudioSource.clip = aClips[20];
                        myAudioSource.Play();
                        break;
                    case "Quad22":
                        myAudioSource.clip = aClips[21];
                        myAudioSource.Play();
                        break;
                    case "Quad23":
                        myAudioSource.clip = aClips[22];
                        myAudioSource.Play();
                        break;
                    case "Quad24":
                        myAudioSource.clip = aClips[23];
                        myAudioSource.Play();
                        break;
                    case "Quad25":
                        myAudioSource.clip = aClips[24];
                        myAudioSource.Play();
                        break;
                    case "Quad26":
                        myAudioSource.clip = aClips[25];
                        myAudioSource.Play();
                        break;
                   


                    default:
                        break;




                }
            }
        }
		
	}
}
