using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System293 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component33,Component210,Component276> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component158>())
   {
    entity.Del<Component158>();
   }
   else
   {
    entity.Replace(new Component158());
   }
  }
 }
}

}
