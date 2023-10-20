// * NAMESPACE HEADER FILE

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pong;

namespace Pong.Ball {
    /*
     * Player lastTouchedBy
     * Destroys the ball and increments points
    */

    /// <summary>
    /// partial class to be later fully defined. Controls how the ball will behave when a player scores a goal
    /// or the ball rebounds off a paddle. May also include how to update the balls postion
    /// </summary>
    public partial class PongBall {}

    /*
     * Handle collisions -> adjust trajectory
       speedX = GameCache.BALL_SPEED_VP
       velocityY = ForceAdjustment => Equation (due to possible derivatives)     
    */

    /// <summary>
    /// define the parital class to be later defined for how the ball will behave
    /// </summary>
    public partial class PongBallController : MonoBehaviour {}

    /*public static class BallStatus {
        private const int GOAL = 1;

        public const int GOAL_LEFT = -GOAL;
        public const int NO_GOAL = 0;
        public const int GOAL_RIGHT = GOAL;
        public const int REBOUNDED = 2;

        public static int INVERT(int ballStatus) {
            return ballStatus * -1;
        }

        public static bool IsGoal(int ballStatus) {
            return Mathf.Abs(ballStatus) == GOAL;
        }
    }*/
    /// <summary>
    /// store who socred the last goal
    /// </summary>
    public static class BallGoal {
        public const bool LEFT = true;
        public const bool RIGHT = false;

        // Note: we don't even need an INVERT() function because the ! operator already does that with bools! 
    }
}