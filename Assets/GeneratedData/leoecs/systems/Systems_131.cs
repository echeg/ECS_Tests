using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System131 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component382,Component12> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component407>())
   {
    entity.Del<Component407>();
   }
   else
   {
    entity.Replace(new Component407());
   }
  }
 }
}

}
