using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunfireScript : MonoBehaviour
{

    public float PauseTime = 0.1f;
    public GameObject GunfireSound;
    public bool Sound = false;

    // Start is called before the first frame update
    void Start()
    {
        GunfireSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            ReadySound();
            Sound = true;
        }

        if(Input.GetMouseButtonUp(0))
        {
            Sound = false;
            GunfireSound.SetActive(false);
        }
    }

    void ReadySound()
    {
        StartCoroutine(StartSound());
        GunfireSound.SetActive(true);
    }

    IEnumerator StartSound()
    {
        yield return new WaitForSeconds(PauseTime);
        if(Sound == true)
        {
            ReadySound();
        }
    }
}
