using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System147 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component209,Component376,Component471> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
  }
 }
}

}
