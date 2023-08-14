using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System111 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component478,Component318,Component257> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var component1 = ref _filter.Get1 (i);
   component1.Field0 += 1;
  }
 }
}

}
