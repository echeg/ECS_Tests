using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System161 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component494,Component277> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var component2 = ref _filter.Get2 (i);
  }
 }
}

}
