using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System288 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component158,Component97,Component473,Component290> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component221>())
   {
    entity.Del<Component221>();
   }
   else
   {
    entity.Replace(new Component221());
   }
  }
 }
}

}
