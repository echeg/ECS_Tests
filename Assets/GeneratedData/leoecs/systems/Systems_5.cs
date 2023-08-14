using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System5 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component38,Component235,Component379,Component189> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var component2 = ref _filter.Get2 (i);
  }
 }
}

}
