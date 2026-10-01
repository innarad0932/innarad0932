using UnityEngine;
using UnityEngine.UI;

public class _0x2b3dc263 : MonoBehaviour
{
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xf905b1bd.Instance._0x4d015912();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xf905b1bd.Instance._0x4a3f24e3());
        else
            this.Button.onClick.AddListener(() => _0xf905b1bd.Instance._0x6698f986(this.PopToShowIndex));
    }

    public bool IsHideAllPops;
    public Button Button;
    public bool IsShowLastPop;
    public int PopToShowIndex;
}