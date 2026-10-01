using UnityEngine;
using UnityEngine.UI;

public class _0x61b6b705 : MonoBehaviour
{
    public Button Button;
    public bool IsPhysicsRunOnClick;
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0xbecc5006.Instance._0x217d0da4(this.IsPhysicsRunOnClick));
    }

    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}