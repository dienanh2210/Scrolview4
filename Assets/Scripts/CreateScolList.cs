using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class item {
    public string name;
    public string Score;
   
    public Sprite face;
    public bool isChampion;

}

public class CreateScolList : MonoBehaviour {
    public List<item> itemList;
    public GameObject sampleButton;
    public Transform contentPanel;
    public Title title;
	// Use this for initialization
	void Start () {
        PopulateList();
	}

    void PopulateList()
    {
        int num = 0;
        foreach (var item in itemList)
        {
            int a =num;
            GameObject newButton = Instantiate(sampleButton) as GameObject;
            newButton.SetActive(true);
            SampleButtonScripts buttonScripts = newButton.GetComponent<SampleButtonScripts>();
            buttonScripts.nameLable.text = item.name;
            buttonScripts.ScoreLable.text = item.Score;
            buttonScripts.faceImage.sprite = item.face;
            buttonScripts.starImage.SetActive(item.isChampion);

            newButton.transform.SetParent(contentPanel);

            newButton.GetComponent<Button>().onClick.AddListener(() => title.SelectLanguage(a));
            num++;
        }
    }
    public void ButtonClicked(string str)
    {
        Debug.Log(str + " button clicked.");

    }
}
