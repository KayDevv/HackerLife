using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogPerson
{
    public Sprite Face;
    public string Name;

    public DialogPerson(string name, string facePath)
    {
        Name = name;
        Face = Resources.Load<Sprite>(facePath);
    }
}

public class DialogPhrase
{
    public DialogPerson Speaker;
    public string Message;

    public DialogPhrase(DialogPerson person, string msg)
    {
        Speaker = person;
        Message = msg;
    }
}

public class Dialog
{
    public enum DialogType
    {
        FIRST_DIALOG
    }

    public DialogType Type;
    public List<DialogPhrase> Phrases = new List<DialogPhrase>();

    public Dialog(DialogType type)
    {
        Type = type;
    }

    public void AddPhrase(DialogPhrase phrase)
    {
        Phrases.Add(phrase);
    }
}

public static class DialogManager
{
    public static List<Dialog> Dialogs = new List<Dialog>();

    public static void AddDialog(Dialog dialog)
    {
        Dialogs.Add(dialog);
    }
}

public class NewBehaviourScript : MonoBehaviour
{
    void Start()
    {
        DialogPerson hack3r = new DialogPerson("HACKER", "hack3e");
        DialogPerson user = new DialogPerson("USER", "user");

        Dialog firstDialog = new Dialog(Dialog.DialogType.FIRST_DIALOG);

        firstDialog.AddPhrase(new DialogPhrase(user, "Привет! Взломай страницу моего босса на http://vk.ru! Логин: b0ss"));
        firstDialog.AddPhrase(new DialogPhrase(gnojniy, "Цена?"));
        //secondDialog.AddPhrase(new DialogPhrase(user, "10.000 рублей"));

        DialogManager.AddDialog(firstDialog);
    }
}


