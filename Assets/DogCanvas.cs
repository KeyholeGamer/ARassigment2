using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DogCanvas : MonoBehaviour
{
    public Slider slider1;
    public Slider slider2;
    public Slider slider3;
    public GameObject ui;
    public GameObject Play;
    public GameObject Feed;
    public GameObject Heal;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(ARPlacement.spawned == false)
        //{
        //    ui.SetActive(false);
        //}
        //if (ARPlacement.spawned == true)
        //{
        //    ui.SetActive(true);
        //}
        slider1.value = PetValue.Doghealth;
        slider2.value = PetValue.Doghunger;
        slider3.value = PetValue.Dogenergy;
    }
    public void ONHeal()
    {
        if(PetValue.Doghealth < 10)
        {
            PetValue.Doghealth++;
        }
    }
    public void OnPlay()
    {
        if(PetValue.Doghunger>0 && PetValue.Dogenergy < 10)
        {
            PetValue.Doghunger--;
            PetValue.Dogenergy++;
        }
    }
    public void OnFeed()
    {
        if (PetValue.Doghunger < 10)
        {
            PetValue.Doghunger++;
        }
    }
    public void OnSwitch()
    {
        SceneManager.LoadScene("Cat");
        ARPlacement.spawned = false;
    }
}
