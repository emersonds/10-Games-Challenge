// Slightly modified Gregoryl's extension to lock Z position:
// https://discussions.unity.com/t/follow-only-along-a-certain-axis/710963/2

using UnityEngine;
using Unity.Cinemachine;

/// <summary>
/// An add-on module for Cinemachine Virtual Camera that locks the camera's Y coordinate
/// </summary>
[ExecuteInEditMode] [SaveDuringPlay] [AddComponentMenu("")] // Hide in menu
public class CinemachineLockY : CinemachineExtension
{
    [Tooltip("Lock the camera's Y position to this value")]
    public float m_YPosition = 0f;

    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
    {
        if (stage == CinemachineCore.Stage.Body)
        {
            var pos = state.RawPosition;
            pos.y = m_YPosition;
            state.RawPosition = pos;
        }
    }
}