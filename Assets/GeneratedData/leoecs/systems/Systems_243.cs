using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System243 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component470,Component133> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component195>())
   {
    entity.Del<Component195>();
   }
   else
   {
    entity.Replace(new Component195());
   }
  }
 }
}

}
