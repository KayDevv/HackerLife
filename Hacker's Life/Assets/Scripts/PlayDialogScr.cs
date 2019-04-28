using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;


public class PlayDialogScr: MonoBehaviour
{
    public Dialog.DialogType DialogType;
    public DialogObjScr Dialog;

    private void Awake()
    {
        DOTween.Init();
    }

    public void StartDialog()
    {
        GetComponent<Button>().enabled = false;
    }

    public void EndDialog()
    {
        GetComponent<Button>().enabled = true;
    }
}
