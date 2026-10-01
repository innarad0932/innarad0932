using UnityEngine;
using UnityEngine.UI;

public class _0xd275198b : MonoBehaviour
{
    public Button NextTutorialButton;
    public int NextTutorialPanelIndex;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3e2c0a04.Instance._0x83b29986(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0xbecc5006.Instance._0xdb555168());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0x3e2c0a04.Instance._0x83b29986(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0x3e2c0a04.Instance._0x83b29986(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0xbecc5006.Instance._0xdb555168());
        }
    }

    public bool IsTutorialEndPanel;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
}