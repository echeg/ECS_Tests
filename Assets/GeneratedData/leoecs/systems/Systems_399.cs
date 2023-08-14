using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System399 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component92,Component120> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component150>())
   {
    entity.Del<Component150>();
   }
   else
   {
    entity.Replace(new Component150());
   }
  }
 }
}

}
