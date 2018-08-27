using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleButtonScripts : MonoBehaviour {
    [SerializeField]
    private Button button;
    public Text nameLable;
    public Text ScoreLable;
  
    public Image faceImage;
    public GameObject starImage;


    public string Name;
 
    public CreateScolList ScrollView;

    public void SetName(string name)
    {
        Name = name;
        nameLable.text = name;
    }
    public void Button_Click()
    {
        ScrollView.ButtonClicked(Name);

    }


}
