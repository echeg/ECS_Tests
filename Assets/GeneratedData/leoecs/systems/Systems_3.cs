using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System3 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component82,Component44,Component383> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

}
