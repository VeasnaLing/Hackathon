using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MainUI : MonoBehaviour{

    [SerializeField]
    private GameObject homePanel;
    [SerializeField]
    private GameObject trackpanel;
    [SerializeField]
    private GameObject infoPanel;
    [SerializeField]
    private GameObject youPanel;
    [SerializeField]
    private GameObject stocktonPanel;
    
    // Start is called before the first frame update

    private void disactivePanels()
    {
         homePanel.gameObject.SetActive(false);
         trackpanel.gameObject.SetActive(false);   
         infoPanel.gameObject.SetActive(false);   
         youPanel.gameObject.SetActive(false);   
         stocktonPanel.gameObject.SetActive(false);
    }

    public void activateHome()
    {
        disactivePanels();
        homePanel.gameObject.SetActive(true);
    }
    public void activateTrack()
    {
        disactivePanels();
        trackpanel.gameObject.SetActive(true);
    }
    
    public void activateInfo()
    {
        disactivePanels();
        infoPanel.gameObject.SetActive(true);
    }
    
    public void activateYou()
    {
        disactivePanels();
        youPanel.gameObject.SetActive(true);
    }
    
    public void activateStockton()
    {
        disactivePanels();
        stocktonPanel.gameObject.SetActive(true);
    }

}
