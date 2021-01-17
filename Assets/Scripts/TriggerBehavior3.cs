using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class TriggerBehavior3 : MonoBehaviour
{
    private Text uiText;

    public string enterXmlPath = "Xml/enter.xml";
    public string exitXmlPath = "Xml/exit.xml";
    private TriggerXml enterTriggerXml;
    private TriggerXml exitTriggerXml;

    void Start()
    {
        uiText = FindObjectOfType<Text>();
        enterTriggerXml = XmlUtils.ImportXml<TriggerXml>(Path.Combine(Application.dataPath, enterXmlPath));
        exitTriggerXml = XmlUtils.ImportXml<TriggerXml>(Path.Combine(Application.dataPath, exitXmlPath));
    }

    void OnTriggerEnter2D(Collider2D _)
    {
        SetUiText(enterTriggerXml);
    }

    void OnTriggerExit2D(Collider2D _)
    {
        SetUiText(exitTriggerXml);
    }

    private void SetUiText(TriggerXml triggerXml)
    {
        uiText.text = triggerXml.text;
        uiText.fontSize = triggerXml.font.size;
        if (triggerXml.font.style.Equals("italic"))
        {
            uiText.fontStyle = FontStyle.Italic;
        } else
        {
            uiText.fontStyle = FontStyle.Normal;
        }
    }
}
