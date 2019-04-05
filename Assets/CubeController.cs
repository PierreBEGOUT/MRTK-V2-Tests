using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.SDK.Input.Handlers;
using UnityEngine;

public class CubeController : BaseFocusHandler
{
    #region Public Fields

    public TextMesh textMesh;

    #endregion Public Fields

    #region Public Methods

    public override void OnFocusEnter(FocusEventData eventData)
    {
        textMesh.text = "User looking at cube";
    }

    public override void OnFocusExit(FocusEventData eventData)
    {
        textMesh.text = "User not looking at cube";
    }

    public void Rotate_Cube()
    {
        textMesh.text = "User wants to rotate Cube";
    }

    public void Select_Cube()
    {
        textMesh.text = "User selected Cube";
    }

    #endregion Public Methods
}