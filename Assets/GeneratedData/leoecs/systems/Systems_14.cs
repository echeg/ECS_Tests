using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System14 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component272,Component169,Component359> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

}
