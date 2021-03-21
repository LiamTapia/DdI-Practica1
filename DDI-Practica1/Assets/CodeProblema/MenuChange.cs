using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuChange : MonoBehaviour
{
    public GameObject panelSelf;
    public GameObject otherPanel;
    public float xPanelSelf = 580f;
    public float xOtherPanel = -500f;

    public void changePanel()
    {
        Vector3 aux = panelSelf.transform.localPosition;
        panelSelf.transform.localPosition  = otherPanel.transform.localPosition;
        otherPanel.transform.localPosition  = aux;
    }
}
