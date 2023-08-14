using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System242 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component334,Component43> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component395>())
   {
    entity.Del<Component395>();
   }
   else
   {
    entity.Replace(new Component395());
   }
  }
 }
}

}
