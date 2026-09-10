using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Attachment;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ToggleNearFarAttach : MonoBehaviour
{
    [Tooltip("Drag your Near-Far Interactor here")]
    public NearFarInteractor nearFarInteractor;

    /// <summary>
    /// Call this from a UI Toggle’s OnValueChanged event.
    /// </summary>
    /// <param name="useFarMode">
    /// true = Far mode (grab stays at ray hit point),
    /// false = Near mode (object snaps to hand).
    /// </param>
    public void SetFarAttachMode(bool useFarMode)
    {
        if (nearFarInteractor == null)
        {
            Debug.LogWarning("NearFarInteractor reference is not assigned!");
            return;
        }

        nearFarInteractor.farAttachMode = useFarMode
            ? InteractorFarAttachMode.Far
            : InteractorFarAttachMode.Near;

        Debug.Log($"Far Attach Mode set to: {nearFarInteractor.farAttachMode}");
    }
}
