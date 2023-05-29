using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CatCanvas : MonoBehaviour
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
        slider1.value = PetValue.Cathealth;
        slider2.value = PetValue.Cathunger;
        slider3.value = PetValue.Catenergy;
    }
    public void ONHeal()
    {
        if(PetValue.Doghealth < 10)
        {
            PetValue.Cathealth++;
        }
    }
    public void OnPlay()
    {
        if(PetValue.Cathunger>0 && PetValue.Catenergy < 10)
        {
            PetValue.Cathunger--;
            PetValue.Catenergy++;
        }
    }
    public void OnFeed()
    {
        if (PetValue.Cathunger < 10)
        {
            PetValue.Cathunger++;
        }
    }
    public void OnSwitch()
    {
        SceneManager.LoadScene("Dog");
        ARPlacement.spawned = false;
    }
}
