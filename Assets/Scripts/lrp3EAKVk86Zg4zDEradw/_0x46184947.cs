using UnityEngine;
using UnityEngine.EventSystems;

// Turns the full-shaft hit area into a hold/release signal. Pointer events are
// used rather than the raw touch stack because they also answer a single adb tap,
// they respect the UI stacking order (the HUD buttons stay pressable) and they do
// not depend on the template's physics-run gate.
public sealed class _0x46184947 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void _0x4fdd0313(System.Action _0x85f55213, System.Action _0xfa9d3ed0)
    {
        this._0x5b30aa67 = _0x85f55213;
        this._0x20bd26db = _0xfa9d3ed0;
    }

    public void OnPointerUp(PointerEventData _0xb007812f)
    {
        if (this._0x20bd26db != null)
        {
            this._0x20bd26db.Invoke();
        }
    }

    private System.Action _0x5b30aa67;
    public void OnPointerDown(PointerEventData _0x2f2a6239)
    {
        if (this._0x5b30aa67 != null)
        {
            this._0x5b30aa67.Invoke();
        }
    }

    private System.Action _0x20bd26db;
}