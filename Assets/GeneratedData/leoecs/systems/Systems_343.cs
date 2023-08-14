using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System343 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component329,Component312,Component307,Component94> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component362>())
   {
    entity.Del<Component362>();
   }
   else
   {
    entity.Replace(new Component362());
   }
  }
 }
}

}
