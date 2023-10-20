// * NAMESPACE HEADER FILE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pong.GamePlayer {
    /// <summary>
    /// future class to be defined of how player information/actoins will be stored
    /// </summary>
    public partial class Player {}
    /// <summary>
    /// playerData class derived from ScriptableObjet to be later deifined
    /// </summary>
    public partial class PlayerData : ScriptableObject {}
    //public partial class AIPlayerData : PlayerData {}
    /// <summary>
    /// partial class on how the player will be controlled
    /// </summary>
    public partial class PlayerController : MonoBehaviour {}

    /// <summary>
    /// class stores keys players will use to control their paddle
    /// </summary>
    public class PlayerControls {
        public readonly KeyCode Up, Down;
        public PlayerControls(KeyCode up, KeyCode down) {
            Up = up;
            Down = down;
        }
    }
}