using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System122 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component436,Component313,Component495,Component142> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var component1 = ref _filter.Get1 (i);
   ref var component2 = ref _filter.Get2 (i);
   component1.Field0 += component2.Field0;
  }
 }
}

}