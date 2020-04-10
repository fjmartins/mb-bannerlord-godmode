using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.MountAndBlade;

namespace Godmode {
    public class Main : MBSubModuleBase {
        protected override void OnApplicationTick(float dt) {
            Agent agent = Agent.Main;

            if (agent != null) {
                // Just in case you get impaled by a huge spear
                agent.Health = agent.HealthLimit * 1000;
            }
        }
    }
}