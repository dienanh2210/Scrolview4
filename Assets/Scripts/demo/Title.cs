using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;


public class Title : MonoBehaviour {

    #region Declare
    [SerializeField]
    List<Button> lstButton;
    [SerializeField]
    Text  txtLanguage;
    public Text demotext;

    public static Title instance;
    #endregion

    #region Init
    void Start()
    {
        
        switch (Application.systemLanguage.ToString())
        {
            case "Japanese":
                SelectJapanese();
                break;
            case "ChineseTraditional":
                SelectChinese1();
                break;
            case "ChineseSimplified":
                SelectChinese2();
                break;
            case "Thai":
                SelectThai();
                break;
            default:
                SelectEnglish();
                break;
        }
    //    txtLanguage.text = Appli.GetLocaleText(LocaleTyp.TermLimitedYokai); //key value language
    }
    #endregion
    #region Language
    //void DisalbeButton(string name)
    //{
    //    try
    //    {
    //        List<Button> lstTemp = lstButton.FindAll(x => x.name != name);
    //        Button bt = lstButton.Find(x => x.name == name);
    //        txtLanguage.text = Appli.GetLocaleText(LocaleTyp.TermLimitedYokai); //key value language
    //    }
    //    catch (System.Exception e)
    //    {

    //        Debug.Log(e.Message);
    //    }
    //}
    public void SelectEnglish()
    {
        Appli.SelectedLanguage = LanguageTyp.English;
       // string abc = Appli.GetLanguage(LocaleTyp.MiddleEnding1);
        SetName("One");

    }
    public void SelectJapanese()
    {
        Appli.SelectedLanguage = LanguageTyp.Japanese;
       // string abc = Appli.GetLanguage(LocaleTyp.MiddleEnding1);
        SetName("Two");

    }
    public void SelectChinese1()
    {
        Appli.SelectedLanguage = LanguageTyp.Chinese1;
      //  string abc = Appli.GetLanguage(LocaleTyp.MiddleEnding1);
        SetName("Three");

    }
    public void SelectChinese2()
    {
        Appli.SelectedLanguage = LanguageTyp.Chinese2;
      //  string abc = Appli.GetLanguage(LocaleTyp.MiddleEnding1);
        SetName("Four");
       // SetName(abc);

    }
    public void SelectThai()
    {
        Appli.SelectedLanguage = LanguageTyp.Thai;
        SetName("Fire");

    }
    private string Name;
    public Text nameLable;
    public CreateScolList ScrollView;

    public void SetName(string name)
    {
        Name = name;
        // ButtonText.text = name;
        nameLable.text = name;
        txtLanguage.text = Appli.GetLocaleText(LocaleTyp.TermLimitedYokai); //key value language
      //  demotext.text = Appli.GetLocaleText(LocaleTyp.TermLimitedYokai); //key value language
    }
    public void Button_Click()
    {
       ScrollView.ButtonClicked(Name);
    }
    public void SelectLanguage(int typeLangage)
    {
        if (typeLangage == 0) SelectEnglish();
        if (typeLangage == 1) SelectJapanese();
        if (typeLangage == 2) SelectChinese1();
        if (typeLangage == 3) SelectChinese2();
        if (typeLangage == 4) SelectThai();
        Debug.Log(typeLangage);
     
    }
    #endregion
}
