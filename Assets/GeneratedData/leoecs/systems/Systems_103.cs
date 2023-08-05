using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System103 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component405,Component433,Component111> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component50>())
   {
    entity.Del<Component50>();
   }
   else
   {
    entity.Replace(new Component50());
   }
  }
 }
}

}
