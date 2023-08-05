using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System102 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component386> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component168>())
   {
    entity.Del<Component168>();
   }
   else
   {
    entity.Replace(new Component168());
   }
  }
 }
}

}
