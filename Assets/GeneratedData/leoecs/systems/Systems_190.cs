using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System190 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component20,Component94> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component121>())
   {
    entity.Del<Component121>();
   }
   else
   {
    entity.Replace(new Component121());
   }
  }
 }
}

}
