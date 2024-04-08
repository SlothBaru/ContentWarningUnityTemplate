# Content Warning Unity Template

### Setup
1. Clone this repository from `https://github.com/hyydsz/ContentWarningUnityTemplate.git`
2. Go into the Content Warning's Managed directory:
    - `Content Warning/Content Warning_Data/Managed`
3. Copy the following files: 
    - `Newtonsoft.Json.dll`
    - `Photon3Unity3D.dll`
    - `PhotonRealtime.dll`
    - `PhotonUnityNetworking.dll`
    - `PhotonUnityNetworking.Utilities.dll`
    - `Sirenix.OdinInspector.Attributes.dll`
    - `Sirenix.Serialization.Config.dll`
    - `Sirenix.Serialization.dll`
    - `Sirenix.Utilities.dll`
    - `Unity.Burst.Unsafe.dll`
    - `Unity.Collections.dll`
    - `Unity.Collections.LowLevel.ILSupport.dll`
    - `Zorro.Core.Runtime.dll`
    - `Zorro.PhotonUtility.dll`
    - `Zorro.Recorder.dll`
    - `Zorro.Settings.Runtime.dll`
    - `Zorro.UI.Runtime.dll`
4. Move the copied files into `ContentWarningUnityTemplate/Assets/Plugins`
5. Open the project with Unity 2022.3.15f1c1 `Whatever`
6. You can now use game scripts inside of this unity project, for creating custom assets! `Just Item Script`

### Script
If the scripts doesn't have what you need

1. Use [dnSpy](https://github.com/dnSpy/dnSpy, "dnSpy") To Export Scripts
2. Copy scripts what you need
3. Paste scripts into `ContentWarningUnityTemplate/Assets/Scripts/Assembly-CSharp`
4. Keep only Field
5. Delete fields as needed
6. You can now use the new script