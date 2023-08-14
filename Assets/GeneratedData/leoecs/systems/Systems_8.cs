using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System8 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component387,Component147,Component389,Component295> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var component1 = ref _filter.Get1 (i);
   ref var component2 = ref _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

}
