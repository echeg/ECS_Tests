using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System137 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component419,Component328> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component449>())
   {
    entity.Del<Component449>();
   }
   else
   {
    entity.Replace(new Component449());
   }
  }
 }
}

}
