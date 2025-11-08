using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlanetInfoUI : MonoBehaviour
{
    public GameObject infoPanel;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public Image planetImage;

    void Start()
    {
        infoPanel.SetActive(false);
    }

    public void ShowInfo(string planetName, string description, Sprite image = null)
    {
        nameText.text = planetName;
        descriptionText.text = description;

        if (planetImage != null)
        {
            if (image != null)
            {
                planetImage.sprite = image;
                planetImage.gameObject.SetActive(true);
            }
            else
            {
                planetImage.gameObject.SetActive(false);
            }
        }

        infoPanel.SetActive(true);
    }

    public void HideInfo()
    {
        infoPanel.SetActive(false);
    }
}
