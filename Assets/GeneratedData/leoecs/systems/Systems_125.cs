using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System125 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component422,Component21> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component65>())
   {
    entity.Del<Component65>();
   }
   else
   {
    entity.Replace(new Component65());
   }
  }
 }
}

}
