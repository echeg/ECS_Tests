using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System251 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component113> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component49>())
   {
    entity.Del<Component49>();
   }
   else
   {
    entity.Replace(new Component49());
   }
  }
 }
}

}
